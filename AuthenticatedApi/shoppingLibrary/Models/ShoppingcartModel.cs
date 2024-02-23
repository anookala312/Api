namespace shoppingLibrary.Models
{
    public class Shoppingcart
    {
        [Key]
        public int ShoppingcartId { get; set; }

        public int UserID { get; set; }

        public List<Product> Product { get; set; } = new List<Product>();

    }
}