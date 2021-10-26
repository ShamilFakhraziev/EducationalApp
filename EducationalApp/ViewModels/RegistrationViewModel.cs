using System.ComponentModel.DataAnnotations;

namespace EducationalApp.ViewModels
{
    public class RegistrationViewModel
    {
        [Required(ErrorMessage ="Введите имя пользователя")]
        [Display(Name ="Имя пользователя")]
        
        public string UserName { get; set; }
        [Required(ErrorMessage = "Введите электронную почту")]
        [Display(Name ="Электронная почта")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; } 


        [Required(ErrorMessage = "Введите пароль")]
        [DataType(DataType.Password)]
        [Display(Name ="Пароль")]
        public string Password { get; set; }      


        [Required(ErrorMessage = "Введите пароль для потверждения")]
        [Compare("Password",ErrorMessage ="Пароли не совпадают")]
        [DataType(DataType.Password)]
        [Display(Name ="Потвердите пароль")]
        public string ConfrimPassword { get; set; }   
    }
}
