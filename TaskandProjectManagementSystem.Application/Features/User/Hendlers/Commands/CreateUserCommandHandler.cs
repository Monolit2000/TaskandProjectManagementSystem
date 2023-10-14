using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using TaskandProjectManagementSystem.Application.Features.User.Requests.Commands;

namespace TaskandProjectManagementSystem.Application.Features.User.Hendlers.Commands
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand,BaseCommandResponse>
    {
        public async Task<BaseCommandResponse> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            var response = new BaseCommandResponse();
            
            return response;
        }
    }
}
