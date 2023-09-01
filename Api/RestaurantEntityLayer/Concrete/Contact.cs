using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantEntityLayer.Concrete
{
    public class Contact
    {
        [Key]
        public int ContactID { get; set; }

        [StringLength(25)]
        public string Name { get; set; }

        [StringLength(50)]
        public string Mail { get; set; }

        [StringLength(30)]
        public string Subject { get; set; }

        [StringLength(200)]
        public string Message { get; set; }
        public DateTime Date { get; set; }

        public int MessageCategoryID { get; set; }

        //public MessageCategory MessageCategory { get; set; }

    }
}
