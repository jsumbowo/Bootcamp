using Microsoft.EntityFrameworkCore;

namespace DBCodeFirst;

public class DataBase : DbContext
{
	public DbSet<Category> Categories {get; set;}
	public DbSet<Product> Products {get; set;}
	//Connect to the database
	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
		optionsBuilder.UseSqlite("FileName=./DataBase.db");
	}
	//Set property and relation of each entity in database
	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		modelBuilder.Entity<Category>(category =>
		{
			category.HasKey(c => c.CategoryId);
			category.Property(c => c.CategoryName).IsRequired(true).HasMaxLength(20);
			category.Property(c => c.Description).IsRequired(true);
		});
		
		modelBuilder.Entity<Product>(product =>
		{
			product.HasKey(p => p.ProductId);
			product.Property(p => p.ProductName).IsRequired(true).HasMaxLength(20);
			product.Property(p => p.UnitPrice).IsRequired(true).HasColumnType("money");
			product.HasOne(p => p.Category).WithMany(c => c.Products).HasForeignKey(p => p.CategoryId);
		});
		//Adding data using DataSeeding
		modelBuilder.Entity<Category>().HasData(
			new Category() 
			{
				CategoryId = 1,
				CategoryName = "Electronic",
				Description = "Bebas"
			},
			new Category() 
			{
				CategoryId = 2,
				CategoryName = "Seafood",
				Description = "Bebas"
			}
		);
		modelBuilder.Entity<Product>().HasData(
			new Product() 
			{
				ProductId = 1,
				ProductName = "Laptop",
				CategoryId = 1,
				UnitPrice = 10
			},
			new Product() 
			{
				ProductId = 2,
				ProductName = "Shrimp",
				CategoryId = 2,
				UnitPrice = 1
			}
		);
	}
	
}
