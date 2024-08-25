using Application.Contracts.Persistence;
using Application.Models;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.BlogPost.Queries.GetAllBlogPost
{
     public class GetAllBlogPostHandler : IRequestHandler<GetAllBlogPostQueries, List<BlogPostDto>>
    {
        private readonly IMapper mapper;
        private readonly IBlogPostRepository blogPostRepository;

        public GetAllBlogPostHandler(IMapper mapper,IBlogPostRepository blogPostRepository) {
            this.mapper = mapper;
            this.blogPostRepository = blogPostRepository;
        }
        public async Task<List<BlogPostDto>> Handle(GetAllBlogPostQueries request, CancellationToken cancellationToken)
        {
            var blogposts = await blogPostRepository.GetAllBlogPosts();

            return mapper.Map<List<BlogPostDto>>(blogposts);

        }
    }
}
