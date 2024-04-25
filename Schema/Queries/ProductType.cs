using System;

namespace RexixBackend.Schema.Queries
{
    public class ProductType
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = "Product";
        public string Description { get; set; } = "Product Description";
        //public List<ReviewType> Reviews { get; set; } = [new ReviewType(), new ReviewType()];
        public string ImageName { get; set; } = "Cover Photo";
        public double Rating { get; set; } = 0.0;
        public string Brand { get; set; } = "Apple";
    }
}