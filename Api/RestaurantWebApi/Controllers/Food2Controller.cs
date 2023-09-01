using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestaurantBusinessLayer.Abstract;
using RestaurantDtoLayer.Dtos.FoodDto;
using RestaurantEntityLayer.Concrete;

namespace RestaurantWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Food2Controller : ControllerBase
    {
        private readonly IFoodService _foodService;
        private readonly IMapper _mapper;

        public Food2Controller(IFoodService foodService, IMapper mapper)
        {
            _foodService = foodService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var values= _foodService.TGetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddFood(FoodAddDto foodAddDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var values = _mapper.Map<Food>(foodAddDto);
            _foodService.TInsert(values);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateFood(FoodUpdateDto updateFoodDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var values = _mapper.Map<Food>(updateFoodDto);
            _foodService.TUpdate(values);
            return Ok("Başarıyla Güncellendi");
        }
    }
}
