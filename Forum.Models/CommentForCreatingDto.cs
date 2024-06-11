using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forum.Models
{
    public class CommentForCreatingDto
    {

        [Required]
        [MaxLength(300)]
        public string Content { get; set; }

        [Required]
        public int TopicId { get; set; }

        [Required]
        public int AuthorId { get; set; }
    }
}
