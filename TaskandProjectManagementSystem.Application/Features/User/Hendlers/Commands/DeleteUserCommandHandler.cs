using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskandProjectManagementSystem.Application.Features.User.Requests.Commands;

namespace TaskandProjectManagementSystem.Application.Features.User.Hendlers.Commands
{
    public class DeleteUserCommandHandler : IRequestHandler<DeleteUserCommand, BaseCommandResponse>
    {
        public Task<BaseCommandResponse> Handle(DeleteUserCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
