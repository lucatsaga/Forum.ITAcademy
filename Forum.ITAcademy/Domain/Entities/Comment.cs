namespace Forum.ITAcademy.Domain.Entities
{
    namespace Forum.Models
    {
        public class Comment
        {

            public int Id { get; set; }
            public int TopicId { get; set; }
            public string Content { get; set; }
            public string Author { get; set; }
            public DateTime CreatedDate { get; set; }

        }
    }
}
