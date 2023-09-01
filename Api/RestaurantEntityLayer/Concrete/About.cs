using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantEntityLayer.Concrete
{
    public class About
    {
        [Key]
        public int AboutID { get; set; }

        [StringLength(25)]
        public string Title1 { get; set; }

        [StringLength(20)]
        public string Title2 { get; set; }

        [StringLength(75)]
        public string Content { get; set; }
        public int FoodCount { get; set; }
        public int StaffCount { get; set; }
        public int CustomerCount { get; set; }
    }
}
