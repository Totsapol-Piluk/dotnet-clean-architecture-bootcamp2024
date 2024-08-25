using Application.Models;
using MediatR;
using Microsoft.AspNetCore.Identity.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Register.Command
{
    public class CreateAccountCommand : IRequest<bool>
    {
        public RegisterRequestDto RegisterModel { get; set; }
    }
}
