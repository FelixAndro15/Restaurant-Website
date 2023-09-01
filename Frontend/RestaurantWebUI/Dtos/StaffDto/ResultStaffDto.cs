using System.ComponentModel.DataAnnotations;

namespace RestaurantWebUI.Dtos.StaffDto
{
    public class ResultStaffDto
    {
        public int StaffID { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
    }
}
