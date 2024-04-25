using RexixBackend.DTOs;
namespace RexixBackend.Services.Review
{
    public interface IReviewRepository
    {
        Task<List<ReviewDTO>> GetAllReviews();
        Task<ReviewDTO> GetReview(Guid id);

        Task<List<ReviewDTO>> AddReview(ReviewDTO Review);

        Task<List<ReviewDTO>> UpdateReview(Guid id, ReviewDTO Review);
        Task<List<ReviewDTO>> DeleteReview(Guid id);
    }
}