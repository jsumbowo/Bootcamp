using System.ComponentModel;
using System.Diagnostics.Tracing;
using Microsoft.EntityFrameworkCore;
namespace SqLiteTutor;
class Program
{
	static async Task Main()
	{
		using(NorthWind db = new())
		
		{
			Console.WriteLine(db.Database.CanConnect());
			IEnumerable<Category> categories = db.Categories.Include(c => c.Products).ToList();
			foreach(var c in categories)
			
			{
				// Console.WriteLine($"{c.CategoryId}: {c.CategoryName}");
				// foreach(var p in c.Products)
				
				// {
				// 	Console.WriteLine($"	{p.ProductId}: {p.ProductName}");
				// }
				
			}
			//Filtering product that has price more than 20
			// Contains
			// Find
			// FirstOrDefault
			// Select
			// Orderly
			IEnumerable<Product> products = db.Products.ToList().Where(p => p.Cost > 20);
			// foreach (var p in products)
			
			// {
			// 	Console.WriteLine($"{p.ProductId}. {p.ProductName}: {p.Cost}");
			// }
		}
		
		using(NorthWind db = new())
		
		{
			// Create new data in database
			Category newCat = new Category()
			{
				CategoryName = "Vehicle",
				Description = "Car and Motorcycle"	
			};
			await db.Categories.AddAsync(newCat);
			await db.SaveChangesAsync();
		}
		using(NorthWind db = new())
		
		{
			//Update database (mau edit description seafood from seaweed & fish -> seaweed, fish, and lobster)
			Category? updateCategory = db.Categories.FirstOrDefault(c => c.CategoryName == "Seafood");
			if(updateCategory is not null)
			
			{
				updateCategory.Description = "Seaweed, fish, and lobster";
			}
			await db.SaveChangesAsync();
		}
		using(NorthWind db = new())
		
		{
			// Delete certain data in database 
			var deleteData = db.Categories.Where(data => data.CategoryName == "Vehicle");
			db.Categories.RemoveRange(deleteData);
			await db.SaveChangesAsync();
		}
	}
}
class NorthWind : DbContext

{
	//vessel for that entity
	public DbSet<Category> Categories {get; set;} 
	public DbSet<Product> Products {get; set;}
	//This method is to connected to database
	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
		optionsBuilder.UseSqlite("FileName=./Northwind.db");
	}

	// Adding realtion and property of Data entity through FLUENT API
	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		base.OnModelCreating(modelBuilder);
		modelBuilder.Entity<Product>(product =>
		
		{
			//Showing which one is PrimaryKey
			product.HasKey(p => p.ProductId);
			//Adding property to such category
			product.Property(p => p.ProductName).IsRequired(true).HasMaxLength(40);
			product.HasOne(p => p.Category).WithMany(c => c.Products).HasForeignKey(p => p.CategoryId);
		});
	}

}