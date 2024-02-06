
using WVCTutor.Models;
using WVCTutor.Repository;

namespace MyMVC.Data.Repository;

public interface ICategoryRepository : IRepository<Category>
{
	void Update(Category category);
}
