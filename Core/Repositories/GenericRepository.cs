
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace Core;

public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
{
    private readonly DbContext _context;
    private readonly DbSet<T> _entity;
    private bool _disposed = false;
    public GenericRepository(DbContext context)
    {
        _context = context;
        _entity = context.Set<T>();
    }

    public async Task Add(T entity)
    {
        try
        {
            await _entity.AddAsync(entity);
            await _context.SaveChangesAsync();
        }
        catch
        {
            throw;
        }
    }

    public async Task AddList(List<T> entities)
    {
        try
        {
            await _entity.AddRangeAsync(entities);
            await _context.SaveChangesAsync();
        }
        catch
        {
            throw;
        }
    }

    public async Task Delete(Guid id)
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
        catch
        {
            throw;
        }
    }

    public async Task DeleteList(List<Guid> ids)
    {
        try
        {
            ids.ForEach(async id =>
            {
                await Delete(id);
            });
        }
        catch
        {
            throw;
        }
    }

    public async Task<IEnumerable<T>> GetAll()
    {
        try
        {
            return await _entity.ToListAsync();
        }
        catch
        {
            throw;
        }
    }

    public async Task<T?> GetById(int id)
    {
        try
        {
            return await _entity.FindAsync(id);
        }
        catch
        {
            throw;
        }
    }

    public async Task Update(T entity)
    {
        try
        {
            _entity.Update(entity);
            await _context.SaveChangesAsync();
        }
        catch
        {
            throw;
        }
    }

    public async Task UpdateList(List<T> entities)
    {

        try
        {
            entities.ForEach(async entity =>
            {
                await Update(entity);
            });
        }
        catch
        {
            throw;
        }
    }
    // public async Task BeginTransaction()
    // {
    //     await _context.Database.BeginTransactionAsync();
    // }

    // public async Task Commit()
    // {
    //     await _context.SaveChangesAsync();
    //     await _context.Database.CommitTransactionAsync();
    // }

    // public async Task Rollback()
    // {
    //     await _context.Database.RollbackTransactionAsync();
    // }

    // public async Task Dispose()
    // {
    //     await Dispose(true);
    //     GC.SuppressFinalize(this);
    // }

    // protected async Task Dispose(bool disposing)
    // {
    //     if (!_disposed)
    //     {
    //         if (disposing)
    //         {
    //             await _context.DisposeAsync();
    //         }
    //     }

    //     _disposed = true;
    // }


    public async Task<IEnumerable<T>> Find(Expression<Func<T, bool>> expression)
    {
        var entity = await _entity.Where(expression).ToListAsync();
        return entity;
    }


}
