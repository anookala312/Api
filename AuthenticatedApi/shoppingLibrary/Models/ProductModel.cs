namespace shoppingLibrary.Models
{
    public class ProductModel
    {
        public int ProductId { get; set; }

        public int ProductPrice { get; set; }

        public string ProductName { get; set; }

        public string ProductDescription { get; set; }

        public int CategoryId { get; set; }

        public CategoryModel Category { get; set; }

    }
}