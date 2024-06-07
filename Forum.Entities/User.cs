using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Forum.Entities
{
    public class User : BaseEntity
    {
        

        [Required]
        [MaxLength(20)]
        public string UserName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        
        public string Password { get; set; }

        [Required]
        public bool IsBanned { get; set; }
        [Required]
        public bool IsAdmin { get; set; }

        
        

        public ICollection<Topic> Topics { get; set; }
        public ICollection<Comment> Comments { get; set; }

        public User()
        {
            Topics = new List<Topic>();
            Comments = new List<Comment>();
        }
    }
}
