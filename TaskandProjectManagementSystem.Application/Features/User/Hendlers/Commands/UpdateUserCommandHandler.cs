using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskandProjectManagementSystem.Application.Features.User.Requests.Commands;

namespace TaskandProjectManagementSystem.Application.Features.User.Hendlers.Commands
{
    public class UpdateUserCommandHandler : IRequestHandler<UpdateUserCommand, BaseCommandResponse>
    {
        public Task<BaseCommandResponse> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
