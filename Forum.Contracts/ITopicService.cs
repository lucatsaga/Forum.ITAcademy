using Forum.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forum.Contracts
{
    public interface ITopicService
    {
        Task<Topic> GetTopicByIdAsync(int id);
        Task<IEnumerable<Topic>> GetAllTopicsAsync();
        Task AddTopicAsync(Topic topic);
        Task UpdateTopicAsync(Topic topic);
        Task DeleteTopicAsync(int id);
    }
}
