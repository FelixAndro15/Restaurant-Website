using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RestaurantWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FileImageController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> UploadImage([FromForm]IFormFile file)
        {
            //yeni dosya adı oluşturdum
            var fileName = Guid.NewGuid() + Path.GetExtension(file.FileName);
            
            //dosyanın kaydedileceği yolu belirttim
            var path=Path.Combine(Directory.GetCurrentDirectory(),"images/" + fileName);
            
            //dosyayı kopyala ve kaydet
            var stream = new FileStream(path, FileMode.Create);
            await file.CopyToAsync(stream);
            return Created("", file);
        }
    }
}
