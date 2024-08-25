using Application.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.BlogPost.Queries.GetAllBlogPost
{
    public class GetAllBlogPostQueries : IRequest<List<BlogPostDto>>
    {
    }
}
