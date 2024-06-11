using Forum.Entities;
using Forum.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forum.Contracts
{
    public interface ITopicService
    {
        Task AddTopicAsync(TopicForCreatingDto model);
        Task DeleteTopicAsync(int id);
        Task<List<TopicDto>> GetAllTopicsAsync();
        Task<TopicDto> GetTopicByIdAsync(int id);
        Task UpdateTopicAsync(TopicForUpdatingDto model);
    }
}
