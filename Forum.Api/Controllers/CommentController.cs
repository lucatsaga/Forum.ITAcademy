using Forum.Contracts;
using Forum.Models;
using Microsoft.AspNetCore.Mvc;
using static Forum.Models.CommentForUpdatingDto;

namespace Forum.Api.Controllers
{
    [Route("api/comments")]
    [ApiController]
    public class CommentController : Controller
    {
        private readonly ICommentService _commentService;

        public CommentController(ICommentService commentService)
        {
            _commentService = commentService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllComments()
        {
            var comments = await _commentService.GetAllCommentsAsync();
            return Ok(comments);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCommentById(int id)
        {
            try
            {
                var comment = await _commentService.GetCommentByIdAsync(id);
                return Ok(comment);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> AddComment([FromBody] CommentForCreatingDto commentDto)
        {
            await _commentService.AddCommentAsync(commentDto);
            return Ok("Comment added successfully");
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateComment(int id, [FromBody] CommentForUpdatingDto commentDto)
        {
            try
            {
                var existingComment = await _commentService.GetCommentByIdAsync(id);
                if (existingComment == null)
                    return NotFound("Comment not found");

               
                await _commentService.UpdateCommentAsync(commentDto);
                return Ok("Comment updated successfully");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteComment(int id)
        {
            try
            {
                await _commentService.DeleteCommentAsync(id);
                return Ok("Comment deleted successfully");
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }
    }
}
