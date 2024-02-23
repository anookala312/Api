using Microsoft.EntityFrameworkCore;
using shoppingLibrary.Models;


namespace shoppingLibrary.Data

public class AppDataContext : DbContext
{
    public AppDataContext(DbContextOptions<AppDataContext> options) 
        : base(options) 
        { }

    public DbSet<CategotyModel> Categories { get; set;}
    public DbSet<ProductModel> Products { get; set;}
    public DbSet<ShoppingcartModel> Shoppingcarts { get; set;}

}