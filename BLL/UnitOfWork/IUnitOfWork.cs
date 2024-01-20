using Core;

namespace BLL;

public interface IUnitOfWork : IDisposable
{
    IActorService actorService { get; }
    IGenreService genreService { get; }
    IMovieActorService movieActorService { get; }
    IMovieGenreService movieGenreService { get; }
    IMovieService movieService { get; }
    IReviewService reviewService { get; }
    IUserRatingService userRatingService { get; }
    IUserService userService { get; }
}