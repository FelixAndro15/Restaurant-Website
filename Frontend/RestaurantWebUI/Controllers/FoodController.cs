using Microsoft.AspNetCore.Mvc;

namespace RestaurantWebUI.Controllers
{
    public class FoodController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
