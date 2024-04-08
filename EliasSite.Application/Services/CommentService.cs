using Elias.Application.Interfaces;
using Elias.Common;
using Elias.Data.Context;
using Elias.Data.Entities.Comment;
using Microsoft.EntityFrameworkCore;

namespace Elias.Application.Services
{
    public class CommentService : ICommentService
    {
        #region Inject DB
        private readonly DatabaseContext _db;
        public CommentService(DatabaseContext db)
        {
            _db = db;
        }


        #endregion
        public void AnswerQuestion(string answer, string Email)
        {
            try
            {
                var body = answer;
                SendEmail.Send(Email, "ارسال پاسخ", body);
            }
            catch (Exception)
            {
            }
        }

        public async Task CreateComment(Comment comment)
        {
            _db.Add(comment);
            await _db.SaveChangesAsync();
        }

        public async Task DeleteComment(Comment comment)
        {
            _db.Remove(comment);
            await _db.SaveChangesAsync();
        }

        public async Task<Comment> FindCommentById(int id)
        {
            return await _db.Comments.FindAsync(id);
        }

        public List<Comment> GetCommentList()
        {
            return _db.Comments
                .AsNoTracking()
                .ToList();
        }

        public bool IsCommentExist()
        {
            return _db.Comments.Any();
        }
    }
}
