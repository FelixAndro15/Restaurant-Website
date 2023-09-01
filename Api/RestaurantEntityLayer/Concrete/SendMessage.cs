using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantEntityLayer.Concrete
{
    public class SendMessage
    {
        [Key]
        public int SendMessageID { get; set; }

        [StringLength(40)]
        public string ReceiverName { get; set; }

        [StringLength(50)]
        public string ReceiverMail { get; set; }

        [StringLength(40)]
        public string SenderName { get; set; }

        [StringLength(50)]
        public string SenderMail { get; set; }

        [StringLength(20)]
        public string Title { get; set; }

        [StringLength(200)]
        public string Content { get; set; }

        public DateTime Date { get; set; }
    }
}
