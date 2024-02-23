namespace shoppingLibrary.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        public string CategoryDescription { get; set; }

    }
}