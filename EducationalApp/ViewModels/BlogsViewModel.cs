using EducationalApp.Models;
using Microsoft.AspNetCore.Identity;

namespace EducationalApp.ViewModels
{
    public class BlogsViewModel
    {
        public Blog Blog { get; set; }
        public IdentityUser User { get; set; }
    }
}
