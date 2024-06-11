using Forum.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forum.Models
{
    public class TopicDto
    {
        public int Id { get; set; }
        public string TopicName { get; set; }
        public int AuthorId { get; set; }
        //public UserDto Author { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public State State { get; set; }
        public Status Status { get; set; }
        public List<CommentDto> Comments { get; set; }

        public TopicDto()
        {
            Comments = new List<CommentDto>();
        }
    }
}
