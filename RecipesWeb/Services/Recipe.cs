namespace RecipesWeb.Services
{
    public class Recipe
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int PrepTimeMinues { get; set; }
        public int TotalCookTimeMinues { get; set; }
        public string Steps { get; set; }
        public short Servings { get; set; }



    }
}