using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forum.Models
{
    public class TopicForCreatingDto
    {
        
            [Required]
            [MaxLength(50)]
            public string TopicName { get; set; }

            [Required]
            public string TopicAuthorId { get; set; }
        
    }
}
