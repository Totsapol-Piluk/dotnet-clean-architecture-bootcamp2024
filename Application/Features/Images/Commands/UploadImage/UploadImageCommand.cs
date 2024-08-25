using Application.Models;
using MediatR;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Images.Commands.UploadImage
{
    public class UploadImageCommand : IRequest<BlogImageDto>
    {
        public IFormFile  File { get; set; }
        public string FileName { get; set; }
        public string Title { get; set; }
    }
}
