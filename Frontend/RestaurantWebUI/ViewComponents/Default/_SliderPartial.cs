using Microsoft.AspNetCore.Mvc;

namespace RestaurantWebUI.ViewComponents.Default
{
    public class _SliderPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }

    }
}
