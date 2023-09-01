using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using RestaurantEntityLayer.Concrete;
using RestaurantWebUI.Dtos.RegisterDto;
using static RestaurantWebUI.Dtos.RegisterDto.CreateNewUserDto;
using AutoMapper;
using System.Xml.Linq;
using Microsoft.AspNetCore.Authorization;

namespace RestaurantWebUI.Controllers
{
    [AllowAnonymous]
    public class RegisterController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public RegisterController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(CreateNewUserDto createNewUserDto)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            var appUser = new AppUser();
            {
                string Name = createNewUserDto.Name;
                string Email = createNewUserDto.Mail;
                string Surname = createNewUserDto.Surname;
                string UserName = createNewUserDto.Username;
                appUser.Name = Name;
                appUser.Email = Email;
                appUser.Surname = Surname;
                appUser.UserName = UserName;
            }
            var result= await _userManager.CreateAsync(appUser, createNewUserDto.Password);
            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Login");
            }
            return View();
        }
    }
}
