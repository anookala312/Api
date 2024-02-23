namespace shoppingLibrary.Models
{
    public class Product
    {
        [Key]
        public string ItemId { get; set; }

        public string Price { get; set; }

        public int Name { get; set; }

        public int Description { get; set; }

    }
}