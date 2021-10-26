using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationalApp.Models
{
    public class Blog
    {
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage ="Укажите заголовок")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Придумайте описание")]
        [MaxLength(200)]
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public bool isCorrect { get; set; }
        
        public DateTime? dateOfPublication { get; set; }
        public string UserId { get; set; }
        public IdentityUser User { get; set; }
        [Required(ErrorMessage = "Напишите содержание")]
        public string Text { get; set; }
    }
}
