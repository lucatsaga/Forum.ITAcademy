using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forum.Entities
{
    public class Comment : BaseEntity
    {
        
        [Required]
        [MaxLength(300)]
        public string Content { get; set; }

        [Required]
        public int TopicId { get; set; }
        [ForeignKey(nameof(TopicId))]
        public Topic Topic { get; set; }

        [Required]
        public int AuthorId { get; set; }
        [Required]
        [ForeignKey(nameof(AuthorId))]
        public User Author { get; set; }

        

        [Required]
        [DataType(DataType.Date)]
        public DateTime UpdatedAt { get; set; }
    }
}
