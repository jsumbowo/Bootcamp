using Microsoft.EntityFrameworkCore;
using WVCTutor.Models;

namespace WVCTutor.Data;

public class DataBase : DbContext
{
	public DbSet<Category> Categories{get; set;}
	public DbSet<Product> Products {get; set;}
	
	public DataBase(DbContextOptions option) : base(option)
	
	{
		
	}

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		//Buat relasinya dulu 
		modelBuilder.Entity<Category>(category=>
		
		{
			category.HasKey(c=> c.CategoryId);
			category.Property(c=> c.CategoryName).IsRequired(true);
			category.HasMany(c=> c.Products).WithOne(p=>p.Category).HasForeignKey(p=> p.CategoryId);
		});
		
		modelBuilder.Entity<Product>(product=>
		
		{
			product.HasKey(p => p.ProductId);
			product.Property(p => p.ProductName).IsRequired(true);
		});
		
	}
	
}
