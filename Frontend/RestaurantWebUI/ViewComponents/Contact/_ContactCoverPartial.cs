using Microsoft.AspNetCore.Mvc;

namespace RestaurantWebUI.ViewComponents.Contact
{
    public class _ContactCoverPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
