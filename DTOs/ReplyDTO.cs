using System;

namespace RexixBackend.DTOs
{
    public class ReplyDTO
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Description { get; set; } = "";
        public PersonDTO User { get; set; } = new PersonDTO();
        public ReviewDTO Review { get; set; } = new ReviewDTO();
        public int Likes { get; set; } = 0;
        public int Dislikes { get; set; } = 0;
        public DateTime Created { get; set; } = DateTime.Now;
    }
}