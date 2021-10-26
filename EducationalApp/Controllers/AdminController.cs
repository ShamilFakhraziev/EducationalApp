using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EducationalApp.Controllers
{
    [Authorize(Roles = "admin")]
    public class AdminController : Controller
    {
        private readonly UserManager<IdentityUser> userManager;
        private readonly RoleManager<IdentityRole> roleManager;
        public AdminController(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            this.roleManager = roleManager;
            this.userManager = userManager;
        }
        public async Task<IActionResult> Index()
        {
            List<IdentityUser> moders = new List<IdentityUser>();
            foreach (var u in await userManager.Users.ToListAsync())
            {
                var s = await userManager.IsInRoleAsync(u, "moder");
                if (s)
                {
                    moders.Add(u);
                }
            }
            return View(moders);
        }

        public async Task<IActionResult> AllUsers()
        {
            List<IdentityUser> users = new List<IdentityUser>();
            foreach(var u in await userManager.Users.ToListAsync())
            {
                var isModer = await userManager.IsInRoleAsync(u, "moder");
                var isAdmin = await userManager.IsInRoleAsync(u, "admin");
                if(!isAdmin && !isModer)
                {
                    users.Add(u);
                }
            }
            return View(users);
        }

        [HttpPost]
        public async Task<IActionResult> AddModer(string id)
        {
            var user = await userManager.FindByIdAsync(id);
            var role = await roleManager.FindByNameAsync("moder");
            await userManager.AddToRoleAsync(user,role.Name);
            return RedirectToAction("AllUsers", "Admin");
        }
       [HttpPost]
       public async Task<IActionResult> DeleteRole(string id)
        {
            var user = await userManager.FindByIdAsync(id);
            await userManager.RemoveFromRoleAsync(user, "moder");
            return RedirectToAction("Index","Admin");
        }
    }
}
