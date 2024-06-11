using Forum.Contracts;
using Forum.Models;
using Microsoft.AspNetCore.Mvc;

namespace Forum.Api.Controllers
{
    [Route("api/topics")]
    [ApiController]
    public class TopicController : ControllerBase
    {
        private readonly ITopicService _topicService;

        public TopicController(ITopicService topicService)
        {
            _topicService = topicService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllTopics()
        {
            var topics = await _topicService.GetAllTopicsAsync();
            return Ok(topics);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetTopicById(int id)
        {
            try
            {
                var topic = await _topicService.GetTopicByIdAsync(id);
                return Ok(topic);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> AddTopic([FromBody] TopicForCreatingDto topicDto)
        {
            await _topicService.AddTopicAsync(topicDto);
            return Ok("Topic added successfully");
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateTopic(int id, [FromBody] TopicForUpdatingDto topicDto)
        {
            try
            {
                var existingTopic = await _topicService.GetTopicByIdAsync(id);
                if (existingTopic == null)
                    return NotFound("Topic not found");

               
                await _topicService.UpdateTopicAsync(topicDto);
                return Ok("Topic updated successfully");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTopic(int id)
        {
            try
            {
                await _topicService.DeleteTopicAsync(id);
                return Ok("Topic deleted successfully");
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }
    }
}
