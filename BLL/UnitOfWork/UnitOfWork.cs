using Core;
using DAL;
using Microsoft.EntityFrameworkCore;

namespace BLL;

public class UnitOfWork : IUnitOfWork
{
    private readonly MovieDbContext _context;
    public UnitOfWork(MovieDbContext context)
    {
        _context = context;
        actorService = new ActorService(context);
        genreService = new GenreService(context);
        movieActorService = new MovieActorService(context);
        movieGenreService = new MovieGenreService(context);
        reviewService = new ReviewService(context);
        userRatingService = new UserRatingService(context);
        userService = new UserService(context);
        movieService = new MovieService(context);
    }


    public IMovieService movieService
    {
        get;
        private set;
    }

    public IActorService actorService
    {
        get;
        private set;
    }


    public IGenreService genreService
    {
        get;
        private set;
    }

    public IMovieActorService movieActorService
    {
        get;
        private set;
    }


    public IMovieGenreService movieGenreService
    {
        get;
        private set;
    }

    public IReviewService reviewService
    {
        get;
        private set;
    }


    public IUserRatingService userRatingService
    {
        get;
        private set;
    }


    public IUserService userService
    {
        get;
        private set;
    }



    public void Dispose()
    {
        throw new NotImplementedException();
    }
}
