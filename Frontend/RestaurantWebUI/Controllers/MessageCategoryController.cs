﻿using Microsoft.AspNetCore.Mvc;

namespace RestaurantWebUI.Controllers
{
    public class MessageCategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
