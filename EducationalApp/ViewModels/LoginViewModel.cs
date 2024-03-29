﻿using System.ComponentModel.DataAnnotations;

namespace EducationalApp.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage ="Введите имя пользователя")]
        [Display(Name ="Имя пользователя")]
        public string UserName { get; set; }

        [Required(ErrorMessage ="Введите пароль")]
        [Display(Name="Пароль")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [Display(Name ="Запомнить?")]
        public bool RememberMe { get; set; }
    }
}
