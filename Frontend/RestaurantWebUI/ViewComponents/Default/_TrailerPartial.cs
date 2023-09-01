using Microsoft.AspNetCore.Mvc;

namespace RestaurantWebUI.ViewComponents.Default
{
    public class _TrailerPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
