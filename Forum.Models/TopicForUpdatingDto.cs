using Forum.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forum.Models
{
    public class TopicForUpdatingDto
    {
        [Required]
        [MaxLength(50)]
        public string TopicName { get; set; }

        [Required]
        public State State { get; set; }

        [Required]
        public Status Status { get; set; }
    }
}
