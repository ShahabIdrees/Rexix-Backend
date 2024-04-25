
namespace RexixBackend.DTOs
{
    public class ProductDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = "Product";
        public string Description { get; set; } = "Product Description";
        //public List<ReviewDTO> Reviews { get; set; } = [];
        public string ImageName { get; set; } = "Cover Photo";
        public double Rating { get; set; } = 0.0;
        public string Brand { get; set; } = "Apple";
    }
}