using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantEntityLayer.Concrete
{
    public class Testimonial
    {
        [Key]
        public int TestimonialID { get; set; }

        [StringLength(20)]
        public string Name { get; set; }

        [StringLength(15)]
        public string Title { get; set; }

        [StringLength(50)]
        public string Description { get; set; }

        [StringLength(15)]
        public string? Image { get; set; }
    }
}
