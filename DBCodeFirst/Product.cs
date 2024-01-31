namespace DBCodeFirst;

public class Product
{
	public int ProductId { get; set; }
	public string ProductName { get; set; } = null!;
	public int CategoryId { get; set; }
	public Category Category { get; set; } = null!;
	public double UnitPrice { get; set; }
}
