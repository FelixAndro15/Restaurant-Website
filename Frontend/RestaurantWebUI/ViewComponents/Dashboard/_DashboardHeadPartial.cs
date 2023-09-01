using Microsoft.AspNetCore.Mvc;

namespace RestaurantWebUI.ViewComponents.Dashboard
{
    public class _DashboardHeadPartial:ViewComponent 
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
