using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Shared.Models;
using ShoppingApi.Data;

public class ShoppingCartService : IShoppingCartService
{
    private readonly AppDataContext _context;
    private readonly UserManager<AppUser> _userManager;

    public ShoppingCartService(AppDataContext context, UserManager<AppUser> userManager)
    {
        _context = context;
        _userManager = userManager;
    }

    public async Task<ShoppingCartModel> GetShoppingCartAsync(string userEmail)
    {
        var user = await _userManager.FindByEmailAsync(userEmail);
        if (user == null)
        {
            return null; // Handle unauthorized access
        }

        var shoppingCart = await _context.ShoppingCarts
            .Include(sc => sc.Products)
            .FirstOrDefaultAsync(sc => sc.UserEmail == userEmail);

        return shoppingCart;
    }

    public async Task CreateShoppingCartAsync(string userEmail)
    {
        if (!await UserHasExistingCartAsync(userEmail))
        {
            var newCart = new ShoppingCartModel
            {
                UserEmail = userEmail
            };

            _context.ShoppingCarts.Add(newCart);
            await _context.SaveChangesAsync();
        }
    }

    public async Task AddItemToCartAsync(string userEmail, int productId)
    {
        var product = await _context.Products.FindAsync(productId);
        if (product == null)
        {
            throw new ArgumentException("Invalid product ID"); // Handle invalid product
        }

        var shoppingCart = await GetShoppingCartAsync(userEmail);

        if (shoppingCart == null)
        {
            await CreateShoppingCartAsync(userEmail);
            shoppingCart = await GetShoppingCartAsync(userEmail);
        }

        if (!shoppingCart.Products.Any(p => p.ProductId == productId))
        {
            shoppingCart.Products.Add(product);
            await _context.SaveChangesAsync();
        }
    }

    public async Task RemoveItemFromCartAsync(string userEmail, int productId)
    {
        var shoppingCart = await GetShoppingCartAsync(userEmail);
        if (shoppingCart == null)
        {
            return; // No cart to remove from
        }

        var itemToRemove = shoppingCart.Products.FirstOrDefault(p => p.ProductId == productId);
        if (itemToRemove != null)
        {
            shoppingCart.Products.Remove(itemToRemove);
            await _context.SaveChangesAsync();
        }
    }

    public async Task<bool> UserHasExistingCartAsync(string userEmail)
    {
        return await _context.ShoppingCarts.AnyAsync(sc => sc.UserEmail == userEmail);
    }
}
