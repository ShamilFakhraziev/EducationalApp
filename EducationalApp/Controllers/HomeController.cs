using EducationalApp.Data;
using EducationalApp.Models;
using EducationalApp.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace EducationalApp.Controllers
{

    public class HomeController : Controller
    {

        private readonly AppDbContext db;
        private readonly UserManager<IdentityUser> userManager;
        public HomeController(AppDbContext db, UserManager<IdentityUser> userManager)
        {
            this.userManager = userManager;
            this.db = db;
        }
        
        public IActionResult About()
        {
            return View();
        }
        public async Task<IActionResult> Index()
        {
            List<BlogsViewModel> blogs = new List<BlogsViewModel>();
            foreach(var s in db.Blogs.ToList())
            {
                if (s.isCorrect == true)
                {
                    blogs.Add(new BlogsViewModel { Blog = s, User = await userManager.FindByIdAsync(s.UserId) });
                }
            }
                return View(blogs);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
