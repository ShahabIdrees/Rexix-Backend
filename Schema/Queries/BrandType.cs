namespace RexixBackend.Schema.Queries
{
    public class BrandType
    {
        public Guid Id { get; } = Guid.NewGuid();
        private string Name { get; set; } = "";
        public int CustomerCount { get; set; } = 0;
        public List<ReviewType> Reviews { get; set; } = [];
        public double Rating { get; set; } = 0;
        public int RatingCount { get; set; } = 0;
        public Location HeadquarterLocation { get; set; } = new Location();
        public string PhoneNumber { get; set; } = "02938494904";
        public string WebURL { get; set; } = "www.rexix.com";
    }
}