using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forum.Models
{
    public class CommentDto
    {
        public int CommentId { get; set; }
        public string Content { get; set; }
        public int TopicId { get; set; }
       // public TopicDto Topic { get; set; }
        public string CommentAuthorId { get; set; }
       // public UserDto Author { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
