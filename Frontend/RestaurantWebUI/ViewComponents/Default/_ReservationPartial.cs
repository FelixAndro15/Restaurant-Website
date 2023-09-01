using Microsoft.AspNetCore.Mvc;

namespace RestaurantWebUI.ViewComponents.Default
{
    public class _ReservationPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
