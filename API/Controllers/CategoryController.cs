using Microsoft.AspNetCore.Mvc;
using MediatR;
using Application.Features.Catagories.Queries.GetAllCatagories;
using Application.Models;
using AutoMapper;
using Application.Features.Catagories.Commands.CreateCategory;
using Application.Features.Catagories.Commands.UpdateCategory;
using Application.Features.Catagories.Commands.DeleteCategory;

namespace API.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase {
        private readonly IMediator mediator;
        private readonly IMapper mapper;

        public CategoryController( IMediator mediator , IMapper mapper )
        {
            this.mediator = mediator;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCatagories() {
            var categories = await mediator.Send(new GetAllCategoriesQuery());
            
            var result = mapper.Map<List<CategoryDto>>(categories);

            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> CteateCatogory([FromBody] CreateCategoryRequestDto request)
        {
            var command = new CreateCategoryCommand()
            {
                request = request
            };
            var result = await mediator.Send(command);

            return Ok(result);
        }

        [HttpPut("{id:guid}")]
        public async Task<IActionResult> UpdateCategory([FromRoute] Guid id, [FromBody]  UpdateCategoryRequestDto request)
        {
            var command = new UpdateCategoryCommand()
            {
                request = request,
                Id = id
            };

            var result = await mediator.Send(command);

            return Ok(result);
        }

        [HttpDelete("{id:guid}")]
        public async Task<IActionResult> DeleteCategory([FromRoute] Guid id, [FromBody] UpdateCategoryRequestDto request)
        {
            var command = new DeleteCategoryCommand() {
                Id = id
            };

            var result = await mediator.Send(command);

            return Ok(result);
        }
    }
}
