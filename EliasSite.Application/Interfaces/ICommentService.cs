using Elias.Data.Entities.Comment;

namespace Elias.Application.Interfaces
{
    public interface ICommentService
    {
        Task<Comment> FindCommentById(int id);
        public List<Comment> GetCommentList();
        void CreateComment(Comment comment);
        Task DeleteComment(Comment comment);
        bool IsCommentExist();
        void AnswerQuestion(string answer, string Email);

    }
}
