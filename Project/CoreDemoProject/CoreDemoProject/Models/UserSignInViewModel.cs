using System.ComponentModel.DataAnnotations;

namespace CoreDemoProject.Models
{
    public class UserSignInViewModel
    {
        [Required(ErrorMessage = "Kullanıcı adı boş geçilemez")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Password boş geçilemez")]
        public string Password { get; set; }
    }
}
