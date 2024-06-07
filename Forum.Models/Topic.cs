using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Forum.Models
{
    public class Topic
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public DateTime CreatedDate { get; set; }
        public string State { get; set; }
        public string Status { get; set; }
        public List<Comment> Comments { get; set; }
    }
}
