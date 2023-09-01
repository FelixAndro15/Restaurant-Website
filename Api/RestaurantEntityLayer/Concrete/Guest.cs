using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantEntityLayer.Concrete
{
    public class Guest
    {
        [Key]
        public int GuestID { get; set; }

        [StringLength(20)]
        public string Name { get; set; }

        [StringLength(20)]
        public string Surname { get; set; }
    }
}
