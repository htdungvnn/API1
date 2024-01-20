using Core;
using DAL;
using Microsoft.EntityFrameworkCore;

namespace BLL;

public class ReviewService : GenericRepository<Review>, IReviewService
{
    public ReviewService(MovieDbContext context) : base(context)
    {
    }
}
