using Bogus;

namespace RexixBackend.Schema.Queries
{
    public class Query
    {
        // Faker<ReviewType> reviewFaker;
        // Faker<ProductType> productFaker;
        // Faker<PersonType> personFaker;
        // Query()
        // {
        //     productFaker = new Faker<ProductType>()
        //            .RuleFor(r => r.Id, f => f.Random.Guid())
        //            .RuleFor(r => r.Name, f => f.Commerce.ProductName())
        //            .RuleFor(r => r.Description, f => f.Lorem.Paragraph())
        //            .RuleFor(r => r.Rating, f => f.Random.Double(0, 5))
        //            .RuleFor(r => r.Brand, f => f.Company.CompanyName());

        //     personFaker = new Faker<PersonType>()
        //    .RuleFor(r => r.Id, f => f.Random.Guid())
        //    .RuleFor(r => r.Name, f => f.Name.FullName())
        //    .RuleFor(r => r.Age, f => f.Random.Int(18, 60))
        //    .RuleFor(r => r.Pattern, f => f.Internet.Url());

        //     //personFaker.RuleFor(r => r.Followers, f => personFaker.Generate(5));


        //     reviewFaker = new Faker<ReviewType>()
        //     .RuleFor(r => r.Id, f => f.Random.Guid())
        //     .RuleFor(r => r.Title, f => f.Lorem.Sentence())
        //     .RuleFor(r => r.Description, f => f.Lorem.Paragraph())
        //     .RuleFor(r => r.Rating, f => f.Random.Double(0, 5));
        //     // .RuleFor(r => r.Product, f => productFaker.Generate())
        //     // .RuleFor(r => r.User, f => f.Random.Guid());


        // }
        public IEnumerable<ReviewType> GetReviews()
        {

            List<ReviewType> Reviews = [new ReviewType(), new ReviewType()];//reviewFaker.Generate(10);
            return Reviews;
        }

        public ReviewType getReviewById(Guid id)
        {
            ReviewType review = new ReviewType();//reviewFaker.Generate();
            review.Id = id;
            return review;

        }

    }
}
public class Review
{
    public int Stars { get; set; }
    public string Commentary { get; set; }
}