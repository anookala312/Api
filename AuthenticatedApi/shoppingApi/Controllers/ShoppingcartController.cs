using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using shoppingLibrary.Data;
using shoppingLibrary.Models;

namespace shoppingApi.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    public class ShoppingCartController : Controller
    {
        private readonly IShoppingCartService _shoppingCartService;

        public ShoppingCartController(IShoppingCartService shoppingCartService)
        {
            _shoppingCartService = shoppingCartService;
        }

        [HttpGet]
        public async Task<IActionResult> GetShoppingCartItems()
        {
            string userEmail = User.Identity.Name;
            var shoppingCart = await _shoppingCartService.GetShoppingCartAsync(userEmail);

            if (shoppingCart == null)
            {
                return NotFound();
            }

            return Ok(shoppingCart.Products);
        }

        [HttpPost]
        public async Task<IActionResult> RemoveItemFromCart(int productId)
        {
            string userEmail = User.Identity.Name;

            if (!await _shoppingCartService.RemoveItemFromCartAsync(userEmail, productId))
            {
                return NotFound(); // Item not found in cart
            }

            return NoContent();
        }

        [HttpPost]
        public async Task<IActionResult> AddItemToCart(int productId)
        {
            string userEmail = User.Identity.Name;

            await _shoppingCartService.AddItemToCartAsync(userEmail, productId);

            return NoContent();
        }
    }
}
