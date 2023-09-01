namespace RestaurantWebUI.Dtos.FoodDto
{
    public class UpdateFoodDto
    {
        public int FoodID { get; set; }
        public string FoodCoverImage { get; set; }
        public int Price { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
