namespace RestaurantWebUI.Dtos.FoodDto
{
    public class CreateFoodDto
    {
        public string FoodCoverImage { get; set; }
        public int Price { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
