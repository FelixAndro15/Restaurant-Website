using System.ComponentModel.DataAnnotations;

namespace RestaurantWebUI.Dtos.GuestDto
{
    public class UpdateGuestDto
    {
        public int GuestID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}
