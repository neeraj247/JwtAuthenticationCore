using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JwtCoreWeb.Models
{
    public class Login
    {
        [Display(Name = "User Name:")]
        [Required(ErrorMessage = "User name is required")]
        public string Username { get; set; }
        [Display(Name = "Password:")]
        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }
    }
}
