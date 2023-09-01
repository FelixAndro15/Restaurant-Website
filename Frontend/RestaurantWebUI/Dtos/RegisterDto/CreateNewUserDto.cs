using System.ComponentModel.DataAnnotations;

namespace RestaurantWebUI.Dtos.RegisterDto
{
    public class CreateNewUserDto
    {
        [Required(ErrorMessage ="ad alanı gereklidir")]
        public string Name { get; set; }

        [Required(ErrorMessage = "soyad alanı gereklidir")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "kullanıcı adı alanı gereklidir")]
        public string Username { get; set; }

        [Required(ErrorMessage = "mail alanı gereklidir")]
        public string Mail { get; set; }

        [Required(ErrorMessage = "şifre alanı gereklidir")]
        public string Password { get; set; }

        [Required(ErrorMessage = "şifre tekrarı alanı gereklidir")]
        [Compare("Password", ErrorMessage = "şifreler uyuşmuyor")]
        public string ConfirmPassword { get; set; }
    }
}
