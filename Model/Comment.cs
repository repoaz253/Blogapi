using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blogapi.Model
{
    public class Comment
    {
        public int Id { get; set; }
        [Required]
        public string Description { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.Now;
        [ForeignKey("Post")]
        public int PostId { get; set; }
        public Post Post { get; set; }
    }
}
