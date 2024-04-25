using RexixBackend.Data;
using RexixBackend.DTOs;

namespace RexixBackend.Services.Reply
{
    public class ReplyRepository : IReplyRepository
    {
        private readonly AppDbContext _context;
        public ReplyRepository(AppDbContext context)
        {
            _context = context;
        }

        public List<ReplyDTO> AddReply(ReplyDTO reply)
        {
            throw new NotImplementedException();
        }

        public List<ReplyDTO> DeleteReply(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<ReplyDTO> GetAllReplies()
        {
            throw new NotImplementedException();
        }

        public ReplyDTO GetReply(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<ReplyDTO> UpdateReply(Guid id, ReplyDTO reply)
        {
            throw new NotImplementedException();
        }
    }
}