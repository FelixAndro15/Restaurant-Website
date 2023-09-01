using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RestaurantWebUI.Dtos.FoodDto;
using RestaurantWebUI.Models.Staff;

namespace RestaurantWebUI.ViewComponents.Default
{
    public class _OurFoodsPartial:ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _OurFoodsPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        { 
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:5065/api/Food");
            if(responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values= JsonConvert.DeserializeObject<List<ResultFoodDto>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
