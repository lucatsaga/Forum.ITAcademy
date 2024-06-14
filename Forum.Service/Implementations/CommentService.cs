using AutoMapper;
using Forum.Contracts;
using Forum.Entities;
using Forum.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Forum.Models.CommentForUpdatingDto;

namespace Forum.Service.Implementations
{
    public class CommentService : ICommentService
    {
        private readonly IRepository<Comment> _commentRepository;
        private readonly IMapper _mapper;

        public CommentService(IRepository<Comment> commentRepository, IMapper mapper)
        {
            _commentRepository = commentRepository;
            _mapper = mapper;
        }

        public async Task AddCommentAsync(CommentForCreatingDto model)
        {
            if (model == null)
                throw new ArgumentNullException("Invalid argument passed");

            var comment = _mapper.Map<Comment>(model);
            await _commentRepository.AddAsync(comment);
        }

        public async Task DeleteCommentAsync(int id)
        {
            if (id <= 0)
                throw new ArgumentException("Invalid argument passed");

            await _commentRepository.DeleteAsync(id);
        }

        public async Task<List<CommentDto>> GetAllCommentsAsync()
        {
            var comments = await _commentRepository.GetAllAsync();
            return _mapper.Map<List<CommentDto>>(comments);
        }

        public async Task<CommentDto> GetCommentByIdAsync(int id)
        {
            if (id <= 0)
                throw new ArgumentException("Invalid argument passed");

            var comment = await _commentRepository.GetByIdAsync(id);
            return _mapper.Map<CommentDto>(comment);
        }

        /*
        public async Task<IEnumerable<Comment>> GetCommentsForTopicAsync(int topicId)
        {
            return await _commentRepository.GetCommentsForTopicAsync(topicId);
        }
        */

        public async Task UpdateCommentAsync(CommentForUpdatingDto model)
        {
            if (model == null)
                throw new ArgumentNullException("Invalid argument passed");

            var comment = _mapper.Map<Comment>(model);
            await _commentRepository.UpdateAsync(comment);
        }

       
    }

}
