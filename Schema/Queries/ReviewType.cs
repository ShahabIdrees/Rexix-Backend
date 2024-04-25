using System;
using Bogus;

namespace RexixBackend.Schema.Queries
{
    public class ReviewType
    {
        public Guid Id { get; set; }
        public string Title { get; set; } = "Review title";
        public string Description { get; set; } = "Review Description";
        public double Rating { get; set; } = 0;
        public ProductType Product { get; set; } = new ProductType();
        public string Profile { get; set; } = "ProfilePlaceHolder";
        public string Image { get; set; } = "CoverPhoto";
        public PersonType User { get; set; } = new PersonType();
        public List<ReplyType> Replies { get; set; } = [];
        public DateTime Created { get; set; } = DateTime.Now;

    }
}