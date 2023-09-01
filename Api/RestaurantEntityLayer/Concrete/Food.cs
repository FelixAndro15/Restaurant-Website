using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantEntityLayer.Concrete
{
    public class Food
    {
        [Key]
        public int FoodID { get; set; }

        [StringLength(15)]
        public string FoodCoverImage { get; set; }
        public int Price { get; set; }
        [StringLength(15)]
        public string Title { get; set; }

        [StringLength(50)]
        public string Description { get; set; }
    }
}
