using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SqLiteTutor;
public class Category
{
	[Key]
	public int CategoryId {get; set;}
	[StringLength(15)]
	public string CategoryName{get; set;} = null!;
	[Column(TypeName = "nText")]
	public string? Description{get;set;}
	public ICollection<Product>? Products {get; set;} = new HashSet<Product>();
}