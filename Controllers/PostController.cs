using AutoMapper;
using Blogapi.Data;
using Blogapi.DTO.Product;
using Blogapi.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Blogapi.Controllers
{
    [Route("api/Post")]
    [ApiController]
    public class PostController : ControllerBase
    {

        private readonly IMapper _mapper;
        private readonly ApplicationDbContext _context;

        public PostController(ApplicationDbContext context, IMapper mapper)
        {
            _mapper = mapper;
            _context = context;

        }
        [HttpGet]
        public IActionResult GetPosts()
        {

            var posts = _context.Posts.ToList();
            return Ok();

        }
        [HttpPost]
        public IActionResult CreatePost([FromBody] PostDTO postdto)
        {

            
                var post = _mapper.Map<Post>(postdto);
                _context.Posts.Add(post);
                _context.SaveChanges();

                return Ok();



            
           
        }
    }
}