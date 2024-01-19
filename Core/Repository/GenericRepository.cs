
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;

namespace Core;

public abstract class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
{
    private readonly DbContext _context;
    private readonly DbSet<T> _entity;
    public GenericRepository(DbContext context)
    {
        _context = context;
        _entity = context.Set<T>();
    }
    public async Task AddAsync(T entity)
    {
        try
        {
            await _entity.AddAsync(entity);
            await _context.SaveChangesAsync();
        }
        catch (System.Exception)
        {

            throw;
        }
    }

    public async Task DeleteAsync(Guid id)
    {
        try
        {
            var entity = await _entity.FindAsync(id);
            if (entity != null)
            {
                _context.Remove(entity);
                await _context.SaveChangesAsync();
            }

        }
        catch (System.Exception)
        {

            throw;
        }
    }

    public async Task<IEnumerable<T>> GetAllAsync()
    {
        try
        {
            return await _entity.ToListAsync();
        }
        catch (System.Exception)
        {

            throw;
        }
    }

    public async Task<T?> GetByIdAsync(int id)
    {
        try
        {
            return await _entity.FindAsync(id);
        }
        catch (System.Exception)
        {

            throw;
        }
    }

    public async Task UpdateAsync(T entity)
    {
        try
        {
            _entity.Update(entity);
            await _context.SaveChangesAsync();
        }
        catch (System.Exception)
        {

            throw;
        }
    }
}
