using EducationalApp.Data;
using EducationalApp.Models;
using EducationalApp.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace EducationalApp.Controllers
{
    [Authorize]
    public class BlogsController : Controller
    {
        private readonly AppDbContext db;
        private readonly IWebHostEnvironment webHost;
        private readonly UserManager<IdentityUser> userManager;
        public BlogsController(AppDbContext db, UserManager<IdentityUser> userManager, IWebHostEnvironment webHost)
        {
            this.webHost = webHost;
            this.userManager = userManager;
            this.db = db;
        }
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            var user = await userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.UserId = user.Id;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Blog blog, IFormFile imagePath)
        {
            if (ModelState.IsValid)
            {
                var user = await userManager.FindByNameAsync(User.Identity.Name);
                ViewBag.UserId = user.Id;
                if (imagePath != null)
                {
                    if (imagePath.FileName.EndsWith("jpeg") || imagePath.FileName.EndsWith("jpg")
                        || imagePath.FileName.EndsWith("png"))
                    {
                        blog.ImagePath = imagePath.FileName;
                        using (var stream = new FileStream(Path.Combine(webHost.WebRootPath, "images/", imagePath.FileName), FileMode.Create))
                        {
                            await imagePath.CopyToAsync(stream);
                        }
                    }
                    else
                    {
                       
                        ModelState.AddModelError(string.Empty, "Формат файла должен соответствовать jpg,jpeg или png");
                        return View(blog);
                    }
                }
                await db.Blogs.AddAsync(blog);
                await db.SaveChangesAsync();
                return RedirectToAction("Index", "Home");
            }
            
            return View(blog);

        }

        [HttpGet]
        public async Task<IActionResult> Read(int id)
        {
            Blog blog = await db.Blogs.FirstOrDefaultAsync(i => i.Id == id);
            if (blog != null)
            {
                if (User.IsInRole("moder") || User.IsInRole("admin"))
                {

                    return View(blog);
                }
                else if (User.Identity.IsAuthenticated)
                {
                    if (blog.isCorrect)
                    {
                        return View(blog);
                    }
                }
            }
            return NotFound();

        }
        [Authorize(Roles = "moder, admin")]
        [HttpGet]
        public async Task<IActionResult> UncheckedBlogs()
        {
            List<BlogsViewModel> blogs = new List<BlogsViewModel>();

            foreach (var s in await db.Blogs.ToListAsync())
            {
                if (s.isCorrect == false)
                {
                    blogs.Add(new BlogsViewModel { Blog = s, User = await userManager.FindByIdAsync(s.UserId) });
                }
            }
            return View(blogs);
        }
        [HttpPost]
        [Authorize(Roles = "moder, admin")]
        public async Task<IActionResult> ApplyBlog(int id)
        {
            Blog blog = await db.Blogs.FirstOrDefaultAsync(i => i.Id == id);
            blog.isCorrect = true;
            blog.dateOfPublication = DateTime.UtcNow;
            db.Blogs.Update(blog);
            await db.SaveChangesAsync();
            return RedirectToAction("UncheckedBlogs", "Blogs");
        }
        [HttpPost]
        [Authorize(Roles = "moder,admin")]
        public async Task<IActionResult> DeleteBlog(int id)
        {
            db.Blogs.Remove(await db.Blogs.FirstOrDefaultAsync(i => i.Id == id));
            await db.SaveChangesAsync();
            return RedirectToAction("UncheckedBlogs", "Blogs");
        }

    }
}
