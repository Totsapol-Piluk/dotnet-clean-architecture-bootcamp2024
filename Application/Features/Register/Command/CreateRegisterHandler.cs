using MediatR;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Register.Command
{
    public class CreateRegisterHandler : IRequestHandler<CreateAccountCommand, bool>
    {
        private readonly UserManager<IdentityUser> userManager;

        public CreateRegisterHandler(UserManager<IdentityUser> userManager)
        {
            this.userManager = userManager;
        }

        public async Task<bool> Handle(CreateAccountCommand request, CancellationToken cancellationToken)
        {
            var user = new IdentityUser
            {
                UserName = request.RegisterModel.Email.Trim(),
                Email = request.RegisterModel.Email.Trim()
            };

            var identityResult = await userManager.CreateAsync(user, request.RegisterModel.Password);
            if(identityResult.Succeeded is false) return false;

            identityResult = await userManager.AddToRolesAsync(user, ["Reader", "Writer"]);
            if(identityResult.Succeeded) return false;

            throw new NotImplementedException();
        }
    }
}
