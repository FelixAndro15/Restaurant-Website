using Microsoft.AspNetCore.Mvc;

namespace RestaurantWebUI.ViewComponents.Default
{
    public class _FooterPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
