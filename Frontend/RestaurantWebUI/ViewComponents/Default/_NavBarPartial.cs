using Microsoft.AspNetCore.Mvc;

namespace RestaurantWebUI.ViewComponents.Default
{
    public class _NavBarPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
