using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Clairvoyant.ViewModels
{
    public class AddUserViewModel
    {
        [Required(ErrorMessage = "Username is required")]
        [StringLength(15, MinimumLength = 5)]
        public string Username { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [StringLength(20, MinimumLength = 6)]
        public string Password { get; set; }

        [Required(ErrorMessage = "VerifyPassword is required")]
        [Compare("Password", ErrorMessage = "The passwords must match!")]
        public string VerifyPassword { get; set; }
    }
}
