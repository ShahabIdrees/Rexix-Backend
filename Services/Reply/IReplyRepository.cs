using RexixBackend.DTOs;

namespace RexixBackend.Services.Reply
{
    public interface IReplyRepository
    {
        List<ReplyDTO> GetAllReplies();
        ReplyDTO GetReply(Guid id);

        List<ReplyDTO> AddReply(ReplyDTO reply);

        List<ReplyDTO> UpdateReply(Guid id, ReplyDTO reply);
        List<ReplyDTO> DeleteReply(Guid id);


        // Add your class members here
    }
}