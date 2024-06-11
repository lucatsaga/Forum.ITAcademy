using AutoMapper;
using Forum.Contracts;
using Forum.Data;
using Forum.Entities;
using Forum.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forum.Service.Implementations
{
    public class TopicService : ITopicService
    {
        private readonly IRepository<Topic> _topicRepository;
        private readonly IMapper _mapper;

        public TopicService(IRepository<Topic> topicRepository, IMapper mapper)
        {
            _topicRepository = topicRepository;
            _mapper = mapper;
        }

        public async Task AddTopicAsync(TopicForCreatingDto model)
        {
            if (model == null)
                throw new ArgumentNullException("Invalid argument passed");

            var topic = _mapper.Map<Topic>(model);
            await _topicRepository.AddAsync(topic);
        }

        public async Task DeleteTopicAsync(int id)
        {
            if (id <= 0)
                throw new ArgumentException("Invalid argument passed");

            await _topicRepository.DeleteAsync(id);
        }

        public async Task<List<TopicDto>> GetAllTopicsAsync()
        {
            var topics = await _topicRepository.GetAllAsync();
            return _mapper.Map<List<TopicDto>>(topics);
        }

        public async Task<TopicDto> GetTopicByIdAsync(int id)
        {
            if (id <= 0)
                throw new ArgumentException("Invalid argument passed");

            var topic = await _topicRepository.GetByIdAsync(id);
            return _mapper.Map<TopicDto>(topic);
        }

        public async Task UpdateTopicAsync(TopicForUpdatingDto model)
        {
            if (model == null)
                throw new ArgumentNullException("Invalid argument passed");

            var topic = _mapper.Map<Topic>(model);
            await _topicRepository.UpdateAsync(topic);
        }
    }
}

