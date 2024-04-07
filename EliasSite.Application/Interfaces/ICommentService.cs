using Elias.Data.Entities.Comment;

namespace Elias.Application.Interfaces
{
    public interface ICommentService
    {
        Task<Comment> FindCommentById(int id);
        public List<Comment> GetCommentList();
        Task CreateComment(Comment comment);
        bool IsCommentExist();
    }
}
