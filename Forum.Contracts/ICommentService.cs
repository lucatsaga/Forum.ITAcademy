using Forum.Entities;
using Forum.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forum.Contracts
{
    public interface ICommentService
    {
        Task AddCommentAsync(CommentForCreatingDto model);
        Task DeleteCommentAsync(int id);
        Task<List<CommentDto>> GetAllCommentsAsync();
        Task<CommentDto> GetCommentByIdAsync(int id);
        Task UpdateCommentAsync(CommentForUpdatingDto model);
        //Task GetCommentsForTopicAsync (int topicId);
    }
}
