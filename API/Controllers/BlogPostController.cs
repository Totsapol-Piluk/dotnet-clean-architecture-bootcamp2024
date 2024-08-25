using Application.Features.BlogPost.Commands;
using Application.Features.BlogPost.Queries.GetAllBlogPost;
using Application.Models;
using MediatR;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using MvcRoute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace API.Controllers
{
    [MvcRoute("api/[controller]")]
    [ApiController]
    public class BlogPostController : ControllerBase
    {
        private readonly IMediator mediator;

        public BlogPostController (IMediator mediator)
        {
            this.mediator = mediator;
        }
        [HttpPost]
        public async Task<IActionResult> CreateBlogPost([FromBody] CreateBlogPostRequestDto request){
            var command = new CreateBlogPostCommand() { Request = request };
            var result = await mediator.Send(command);
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllBlogPost()
        {
            var result = await mediator.Send(new GetAllBlogPostQueries());
            return Ok(result);
        }
    }
}