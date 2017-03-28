using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Komis_motocykli.ViewModels
{
    public class LoginViewModels
    {
        [Required(ErrorMessage = "Musisz wprowadzić adres email")]
        [EmailAddress]
        public string Email { get; set; }
        [Required(ErrorMessage = "Musis wprowadzić hasło")]
        [DataType(DataType.Password)]
        [Display(Name = "Hasło")]
        public string Password { get; set; }

        [Display(Name = "Zapamiętaj mnnie")]
        public bool RememberMe { get; set; }
    }


    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [StringLength(30, ErrorMessage = "{0} musi mieć co najmniej {2} znaków.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = " Hasło ")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Potwierdz Hasło ")]
        [Compare("Password", ErrorMessage = "Hasło i potwierdzenie hasła nie pasują do siebie.")]
        public string ConfirmPassword { get; set; }
    }


}