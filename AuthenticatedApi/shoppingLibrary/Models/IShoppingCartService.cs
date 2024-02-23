namespace shoppingLibrary.Models
{
    public interface IShoppingCartService
    {
        Task<ShoppingCartModel> GetShoppingCartAsync(string userEmail);
        Task CreateShoppingCartAsync(string userEmail);
        Task AddItemToCartAsync(string userEmail, int productId);
        Task RemoveItemFromCartAsync(string userEmail, int productId);
        Task<bool> UserHasExistingCartAsync(string userEmail); // Added for efficiency
    }
}