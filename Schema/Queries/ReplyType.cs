using System;

namespace RexixBackend.Schema.Queries
{
    public class ReplyType
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Description { get; set; } = "";
        public PersonType User { get; set; } = new PersonType();
        public ReviewType Review { get; set; } = new ReviewType();
        public int Likes { get; set; } = 0;
        public int Dislikes { get; set; } = 0;
        public DateTime Created { get; set; } = DateTime.Now;
    }
}