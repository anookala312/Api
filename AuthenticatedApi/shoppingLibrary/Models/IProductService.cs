namespace shoppingLibrary.Models
{
    public interface IProductService
    {
        Task<IEnumerable<ProductModel>> GetAllProductsAsync();
        Task<IEnumerable<ProductModel>> GetProductsByCategoryIdAsync(int categoryId);
        Task AddProductAsync(ProductModel product);
        Task UpdateProductAsync(ProductModel product);
        Task DeleteProductAsync(int productId);

    }
}