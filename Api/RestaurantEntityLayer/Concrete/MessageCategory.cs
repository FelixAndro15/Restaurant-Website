using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantEntityLayer.Concrete
{
    public class MessageCategory
    {
        [Key]
        public int MessageCategoryID { get; set; }

        [StringLength(25)]

        public string MessageCategoryName { get; set; }

        public List<Contact> Contacts { get; set; }
    }
}
