namespace shoppingLibrary.Models
{
    public class ShoppingcartModel
    {
        public int ShoppingcartId { get; set; }

        public int UserID { get; set; }

        public string UserEmail { get; set; }

        public List<ProductModel> Products { get; set; } = new List<ProductModel>();

    }
}