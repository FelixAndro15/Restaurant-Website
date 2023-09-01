using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantEntityLayer.Concrete
{
    public class Subscribe
    {
        [Key]
        public int SubscribeID { get; set; }

        [StringLength(45)]
        public string Mail { get; set; }
    }
}
