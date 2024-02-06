namespace WVCTutor.Models;

public class Product
{
	public int ProductId {get; set;}
	public string ProductName {get; set;} = null!;
	public string? Description {get; set;}
	public Category? Category {get; set;}
	public int CategoryId{get; set;}
}