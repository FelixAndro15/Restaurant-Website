using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantDtoLayer.Dtos.FoodDto
{
    public class FoodAddDto
    {
        [Required(ErrorMessage ="lütfen yemek giriniz")]
        public string Title { get; set; }
        public string FoodCoverImage { get; set; }

        [Required(ErrorMessage = "lütfen fiyat bilgisi giriniz")]
        public int Price { get; set; }
        public string Description { get; set; }
    }
}
