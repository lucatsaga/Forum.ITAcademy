using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forum.Models
{
    public class CommentForUpdatingDto
    {
        
          

            [Required]
            [MaxLength(300)]
            public string Content { get; set; }
        
    }
}
