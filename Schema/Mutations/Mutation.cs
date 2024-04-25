
using System.ComponentModel;
using RexixBackend.Schema.Queries;

namespace RexixBackend.Schema.Mutations
{
    public class Mutation
    {
        private readonly List<ReviewType> reviews = [];
        public Mutation()
        {

        }
        public bool AddReview(Guid id, string title, string description, double rating, string profile, string image)
        {
            ReviewType newReview = new()
            {
                Id = id,
                Title = title,
                Description = description,
                Rating = rating,
                Product = new ProductType() { Id = Guid.NewGuid() },
                Profile = profile,
                Image = image,
                User = new PersonType() { Id = Guid.NewGuid() },
            };
            reviews.Add(newReview);
            return true;
        }


    }
}