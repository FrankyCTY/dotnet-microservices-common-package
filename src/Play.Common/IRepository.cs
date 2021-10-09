using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Play.Common
{
	public interface IRepository<T> where T : IEntity
	{
		Task CreateAsync(T entity);
		Task<IReadOnlyCollection<T>> GetAllAsync();
		Task<IReadOnlyCollection<T>> GetAllAsync(Expression<Func<T, bool>> filter);
		Task<T> GetAsync(Guid id);
		Task<T> GetAsync(Guid id, Expression<Func<T, bool>> filter);
		Task UpdateAsync(T entity);
		Task DeleteAsync(Guid id);
	}
}