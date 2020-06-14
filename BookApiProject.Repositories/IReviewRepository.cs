using System.Collections.Generic;
using BookApiProject.Entities.Models;


namespace BookApiProject.Repositories
{
    public interface IReviewRepository
    {
        ICollection<Review> GetReviews();
        Review GetReview(int reviewId);
        ICollection<Review> GetReviewsOfABook(int bookId);
        Book GetBookOfAReview(int reviewId);
        bool ReviewExists(int reviewId);

        bool CreateReview(Review review);
        bool UpdateReview(Review review);
        bool DeleteReview(Review review);
        bool DeleteReviews(List<Review> reviews);
        bool Save();
    }
}
