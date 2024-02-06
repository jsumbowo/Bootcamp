using MyMVC.Data.Repository;
using WVCTutor.Data;
using WVCTutor.Models;

namespace WVCTutor.Repository;

public class CategoryRepository : Repository<Category>, ICategoryRepository
{
    public CategoryRepository(DataBase data) : base(data)
    {
    }
    public void Update(Category category) 
    {
        db.Update(category);
    }
}

