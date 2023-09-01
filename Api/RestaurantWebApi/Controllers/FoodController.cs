﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestaurantBusinessLayer.Abstract;
using RestaurantEntityLayer.Concrete;

namespace RestaurantWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FoodController : ControllerBase
    {
        private readonly IFoodService _foodService;

        public FoodController(IFoodService foodService)
        {
            _foodService = foodService;
        }

        [HttpGet]
        public IActionResult FoodList()
        {
            var values = _foodService.TGetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddFood(Food food)
        {
            _foodService.TInsert(food);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteFood(int id)
        {
            var values = _foodService.TGetById(id);
            _foodService.TDelete(values);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateFood(Food food)
        {
            _foodService.TUpdate(food);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetFood(int id)
        {
            var values = _foodService.TGetById(id);
            return Ok(values);
        }
    }
}
