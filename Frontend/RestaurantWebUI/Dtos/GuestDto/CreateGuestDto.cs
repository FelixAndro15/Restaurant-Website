using System.ComponentModel.DataAnnotations;

namespace RestaurantWebUI.Dtos.GuestDto
{
    public class CreateGuestDto
    {
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}
