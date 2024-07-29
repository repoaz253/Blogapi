using System.ComponentModel.DataAnnotations;

namespace Blogapi.DTO.Product
{
    public class PostDTO
    {

       // public int Id { get; set; }
        [Required]
       
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public string Author { get; set; }

        public string Category { get; set; }

    }
}
