using Forum.Contracts;
using Forum.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using static Forum.Models.CommentForUpdatingDto;

namespace Forum.Api.Controllers
{
    [Route("api/comments")]
    [ApiController]
    public class CommentController : Controller
    {
        private readonly ICommentService _commentService;
        private ApiResponse _response;

        public CommentController(ICommentService commentService)
        {
            _commentService = commentService;
            _response = new();
           
        }

        [HttpGet]
        public async Task<IActionResult> GetAllComments()
        {
           

            try
            {
                var comments = await _commentService.GetAllCommentsAsync();
                _response.Result = null;
                _response.IsSucess = true;
                _response.StatusCode = Convert.ToInt32(HttpStatusCode.OK);
                _response.Message = "Request Completed Successfully";
            }
            catch (Exception ex)
            {
                _response.Result = null;
                _response.IsSucess = false;
                _response.StatusCode = Convert.ToInt32(HttpStatusCode.NotFound);
                _response.Message = ex.Message;
            }
            return StatusCode(_response.StatusCode, _response);
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
