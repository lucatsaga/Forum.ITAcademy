using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Forum.Entities
{
    public class Topic
    {
        /*
        
        [Required]
        [MaxLength(50)]
        public string TopicName { get; set; }

        [Required]
        
        public int AuthorId { get; set; }
        [ForeignKey(nameof(AuthorId))]
        public User Author { get; set; }

        
        [Required]
        [DataType(DataType.Date)]
        public DateTime UpdatedAt { get; set; }
        [Required]
        public State State { get; set; } = State.Pending;
        [Required]
        public Status Status { get; set; } = Status.Active;
            
        public ICollection<Comment> Comments { get; set; }

       
        
        public Topic()
        {
            Comments = new List<Comment>();
        }
        
        
        */



        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TopicId { get; set; }


        [Required]
        [MaxLength(50)]
        public string TopicName { get; set; }


        //[Required]
        //[MaxLength(300)]
        //public string Content { get; set; }

        [Required]
        public int NumberOfComments => Comments?.Count ?? 0;

        

        [Required]
        public User TopicAuthor { get; set; }

        [Required]
        public string TopicAuthorId { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime CreatedAt { get; set; }

        [Required]
        public State State { get; set; } = State.Pending;

        [Required]
        public Status Status { get; set; } = Status.Active;

        public ICollection<Comment> Comments { get; set; }

    }
}
