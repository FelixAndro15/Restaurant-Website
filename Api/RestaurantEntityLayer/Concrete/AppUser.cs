using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantEntityLayer.Concrete
{
    public class AppUser:IdentityUser<int>
    {
        [StringLength(15)]
        public string Name { get; set; }

        [StringLength(15)]
        public string Surname { get; set; }

        public string? ImageUrl { get; set; }
    }
}
