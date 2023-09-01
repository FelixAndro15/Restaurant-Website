namespace RestaurantWebUI.Dtos.BookingDto
{
    public class ResultLast6BookingDto
    {
        public int BookingID { get; set; }
        public string Name { get; set; }
        public string Mail { get; set; }
        public DateTime Checkin { get; set; }
        public string PeopleCount { get; set; }
        public string SpecialRequest { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
    }
}
