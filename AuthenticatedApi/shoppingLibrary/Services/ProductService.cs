using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using shoppingLibrary.Models;
using shoppingLibrary.Data;

namespace shoppingLibrary.Services
{
public class ProductService : IProductService
{
    private readonly AppDataContext _context;

    public ProductService(AppDataContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<ProductModel>> GetAllProductsAsync()
    {
        return await _context.Products.AnyAsyncEnumerable().ToListAsync();
    }

    public async Task<IEnumerable<ProductModel>> GetProductsByCategoryIdAsync(int categoryId)
    {
        return await _context.Products.Where(p => p.CategoryId == categoryId).AnyAsyncEnumerable().ToListAsync();
    }

    public async Task AddProductAsync(ProductModel product)
    {
        _context.Products.Add(product);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateProductAsync(ProductModel product)
    {
        // Implement logic to update product in database
        await _context.SaveChangesAsync();
    }

    public async Task DeleteProductAsync(int productId)
    {
        var product = await _context.Products.FindAsync(productId);
        if (product != null)
        {
            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
        }
    }
}
}