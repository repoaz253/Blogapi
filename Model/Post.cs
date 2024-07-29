using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace Blogapi.Model
{
    public class Post
    {
       public int Id { get; set; }
        [Required]
       
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public string Author { get; set; }

        public string Category { get; set; }

        public List<Comment> comments { get; set; } = new List<Comment>();

    }
}
