using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestaurantBusinessLayer.Abstract;

namespace RestaurantWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DashboardWidgetsController : ControllerBase
    {
        private readonly IStaffService _staffService;
        private readonly IBookingService _bookingService;
        private readonly IFoodService _foodService;
        public DashboardWidgetsController(IStaffService staffService, IBookingService bookingService, IFoodService foodService)
        {
            _staffService = staffService;
            _bookingService = bookingService;
            _foodService = foodService;
        }
        [HttpGet("StaffCount")]
        public IActionResult StaffCount()
        {
            var value = _staffService.TGetStaffCount();
            return Ok(value);
        }
        [HttpGet("BookingCount")]
        public IActionResult BookingCount()
        {
            var value = _bookingService.TGetBookingCount();
            return Ok(value);
        }
        [HttpGet("FoodCount")]
        public IActionResult FoodCount()
        {
            var value = _foodService.TFoodCount();
            return Ok(value);
        }
    }
}
