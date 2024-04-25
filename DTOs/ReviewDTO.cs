
namespace RexixBackend.DTOs
{
    public class ReviewDTO
    {
        public Guid Id { get; set; }
        public string Title { get; set; } = "Review title";
        public string Description { get; set; } = "Review Description";
        public double Rating { get; set; } = 0;
        public ProductDTO Product { get; set; } = new ProductDTO();
        public string Profile { get; set; } = "ProfilePlaceHolder";
        public string Image { get; set; } = "CoverPhoto";
        public PersonDTO User { get; set; } = new PersonDTO();
        public List<ReplyDTO> Replies { get; set; } = [];
        public DateTime Created { get; set; } = DateTime.Now;

    }
}