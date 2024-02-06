using System.Linq.Expressions;
using WVCTutor.Data;

namespace WVCTutor.Repository;

public interface IRepository<T> where T: class
{
	public IEnumerable<T> GetAll();
	public T Get(Expression<Func<T, bool>> expression);
	public void Add(T entity);
	public void AddRange(IEnumerable<T> entities);
	public void Remove(T entity);
	
	public void RemoveRange(IEnumerable<T> entity);
	
	public int Save();
	public Task<int> SaveAsync();	
}
