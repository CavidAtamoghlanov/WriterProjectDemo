using System.ComponentModel.DataAnnotations;

namespace CoreDemoProject.Models
{
    public class UserSignUpViewModel
    {
        [Display(Name ="Kullanıcı Adı")]
        [Required(ErrorMessage = "Kullanıcı adı boş geçilemez")]
        public string NameSurname { get; set; }

        [Display(Name = "Password")]
        [Required(ErrorMessage = "Password boş geçilemez")]
        public string Password { get; set; }

        [Display(Name = "Confirm Password")]
        [Compare("Password", ErrorMessage = "Şifreler uyuşmuyor")]
        public string ConfirmPassword { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "Email boş geçilemez")]
        public string Email { get; set; }

        [Display(Name = "Username")]
        [Required(ErrorMessage = "Username boş geçilemez")]
        public string UserName { get; set; }
    }
}
