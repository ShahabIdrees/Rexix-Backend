using Microsoft.EntityFrameworkCore;

namespace RexixBackend.DTOs
{
    public class BrandDTO
    {

        public Guid Id { get; set; } = Guid.NewGuid();
        private string Name { get; set; } = "";
        public int CustomerCount { get; set; } = 0;
        public List<ReviewDTO> Reviews { get; set; } = [];
        public double Rating { get; set; } = 0;
        public int RatingCount { get; set; } = 0;

        //public Location HeadquarterLocation { get; set; } = new Location();
        public string PhoneNumber { get; set; } = "02938494904";
        public string WebURL { get; set; } = "www.rexix.com";
    }
}