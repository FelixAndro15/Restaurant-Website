using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RestaurantWebUI.Dtos.FollowersDto;

namespace RestaurantWebUI.ViewComponents.Dashboard
{
    public class _DashboardSubscribeCountPartial:ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://instagram-profile1.p.rapidapi.com/getprofileinfo/thg_3"),
                Headers =
    {
        { "X-RapidAPI-Key", "8d66a31fa6mshb85c4622d84c29dp105c38jsncdde2c90623a" },
        { "X-RapidAPI-Host", "instagram-profile1.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                ResultInstagramFollowersDto resultInstagramFollowersDtos = JsonConvert.DeserializeObject<ResultInstagramFollowersDto>(body);
                ViewBag.v1=resultInstagramFollowersDtos.followers;
                ViewBag.v2 = resultInstagramFollowersDtos.following;
            }


            var client2 = new HttpClient();
            var request2 = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://twitter32.p.rapidapi.com/getProfile?username=tompetty"),
                Headers =
    {
        { "X-RapidAPI-Key", "8d66a31fa6mshb85c4622d84c29dp105c38jsncdde2c90623a" },
        { "X-RapidAPI-Host", "twitter32.p.rapidapi.com" },
    },
            };
            using (var response2 = await client2.SendAsync(request2))
            {
                response2.EnsureSuccessStatusCode();
                var body2 = await response2.Content.ReadAsStringAsync();
                ResultTwitterFollowersDto resultTwitterFollowersDtos = JsonConvert.DeserializeObject<ResultTwitterFollowersDto>(body2);
                ViewBag.v3 = resultTwitterFollowersDtos.data.user_info.followers_count;
                ViewBag.v4 = resultTwitterFollowersDtos.data.user_info.friends_count;
            }


            var client3 = new HttpClient();
            var request3 = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://fresh-linkedin-profile-data.p.rapidapi.com/get-linkedin-profile?linkedin_url=https%3A%2F%2Fwww.linkedin.com%2Fin%2Ftunahan-g%25C3%25B6k-939399253%2F"),
                Headers =
    {
        { "X-RapidAPI-Key", "8d66a31fa6mshb85c4622d84c29dp105c38jsncdde2c90623a" },
        { "X-RapidAPI-Host", "fresh-linkedin-profile-data.p.rapidapi.com" },
    },
            };
            using (var response3 = await client3.SendAsync(request3))
            {
                response3.EnsureSuccessStatusCode();
                var body3 = await response3.Content.ReadAsStringAsync();
                ResultLinkedinFollowersDto resultLinkedinFollowersDtos = JsonConvert.DeserializeObject<ResultLinkedinFollowersDto>(body3);
                ViewBag.v5 = resultLinkedinFollowersDtos.data.followers_count;
            }
            return View();
        }
    }
}
