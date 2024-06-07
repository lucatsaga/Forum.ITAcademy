using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Forum.Services
{
    public class TopicService : ITopicService
    {
        private readonly IRepository<Topic> _topicRepository;

        public TopicService(IRepository<Topic> topicRepository)
        {
            _topicRepository = topicRepository;
        }

        public async Task<Topic> GetTopicByIdAsync(int id)
        {
            return await _topicRepository.GetByIdAsync(id);
        }

        public async Task<IEnumerable<Topic>> GetAllTopicsAsync()
        {
            return await _topicRepository.GetAllAsync();
        }

        public async Task AddTopicAsync(Topic topic)
        {
            await _topicRepository.AddAsync(topic);
        }

        public async Task UpdateTopicAsync(Topic topic)
        {
            await _topicRepository.UpdateAsync(topic);
        }

        public async Task DeleteTopicAsync(int id)
        {
            await _topicRepository.DeleteAsync(id);
        }
    }
}
