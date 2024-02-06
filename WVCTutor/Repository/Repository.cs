using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using WVCTutor;
using WVCTutor.Data;
namespace WVCTutor.Repository;

public class Repository<T> : IRepository<T> where T : class

{
	protected DataBase dataBase;
	protected DbSet<T> db;
	public Repository(DataBase dataBase)
	
	{
		this.dataBase = dataBase;
		db = dataBase.Set<T>();
	}
		
	public void Add(T entity)
	{
		db.Add(entity);
	}

	public void AddRange(IEnumerable<T> entities)
	{
		db.AddRange(entities);
	}

	public T Get(Expression<Func<T, bool>> expression)
	{
		return db.FirstOrDefault(expression);
	}

	public IEnumerable<T> GetAll()
	{
		return db.ToList();
	}

	public void Remove(T entity)
	{
		db.Remove(entity);
	}

	public void RemoveRange(IEnumerable<T> entity)
	{
		db.RemoveRange(entity);
	}

	public int Save()
	{
		return dataBase.SaveChanges();
	}

	public Task<int> SaveAsync()
	{
		return dataBase.SaveChangesAsync();
	}

}
