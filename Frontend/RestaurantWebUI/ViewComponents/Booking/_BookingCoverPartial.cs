using Microsoft.AspNetCore.Mvc;

namespace RestaurantWebUI.ViewComponents.Booking
{
    public class _BookingCoverPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
