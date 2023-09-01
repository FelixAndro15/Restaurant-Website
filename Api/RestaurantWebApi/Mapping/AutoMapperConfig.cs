using AutoMapper;
using RestaurantDtoLayer.Dtos.FoodDto;
using RestaurantEntityLayer.Concrete;

namespace RestaurantWebApi.Mapping
{
    public class AutoMapperConfig:Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<FoodAddDto, Food>();
            CreateMap<Food, FoodAddDto>();

            CreateMap<FoodUpdateDto, Food>().ReverseMap();
        }
    }
}
