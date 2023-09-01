using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantEntityLayer.Concrete
{
    public class Booking
    {
        [Key]
        public int BookingID { get; set; }
        
        [StringLength(20)]
        public string Name { get; set; }
        
        [StringLength(45)]
        public string Mail { get; set; }
        public DateTime Checkin { get; set; }
        public string PeopleCount { get; set; }

        [StringLength(70)]
        public string SpecialRequest { get; set; }

        [StringLength(70)]
        public string Description { get; set; }

        [StringLength(30)]
        public string Status { get; set; }
    }
}
