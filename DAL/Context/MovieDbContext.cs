using Core;
using Microsoft.EntityFrameworkCore;

namespace DAL;

public class MovieDbContext : DbContext
{
    public DbSet<Movie> Movies { get; set; }
    public DbSet<Actor> Actors { get; set; }
    public DbSet<Genre> Genres { get; set; }
    public DbSet<MovieActor> MovieActors { get; set; }
    public DbSet<MovieGenre> MovieGenres { get; set; }
    public DbSet<Review> Reviews { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<UserRating> UserRatings { get; set; }
    public MovieDbContext(DbContextOptions<MovieDbContext> options) : base(options)
    {
    }

    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        UpdateAuditFields();
        return base.SaveChangesAsync(cancellationToken);
    }

    private void UpdateAuditFields()
    {
        var entries = ChangeTracker.Entries()
            .Where(entry => entry.Entity is BaseEntity && (entry.State == EntityState.Added || entry.State == EntityState.Modified));

        foreach (var entry in entries)
        {
            var entity = (BaseEntity)entry.Entity;
            var currentTime = DateTime.Now;

            if (entry.State == EntityState.Added)
            {
                entity.CreatedAt = currentTime;
                // Set the UserId to the current user's ID (assuming you have access to it)
                // entity.UserId = GetCurrentUserId(); // Implement GetCurrentUserId as needed
            }

            entity.UpdatedAt = currentTime;
        }
    }
}
