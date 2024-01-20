using System.Linq.Expressions;

namespace Core;

public interface IGenericRepository<T> where T : BaseEntity
{
    Task<T?> GetById(int id);
    Task<IEnumerable<T>> GetAll();
    Task Add(T entity);
    Task Update(T entity);
    Task Delete(Guid id);
    Task AddList(List<T> entity);
    Task UpdateList(List<T> entity);
    Task DeleteList(List<Guid> id);
    // Task BeginTransaction();

    // Task Commit();

    // Task Rollback();

    // Task Dispose();

    // Task Dispose(bool disposing);
    Task<IEnumerable<T>> Find(Expression<Func<T, bool>> expression);
}
