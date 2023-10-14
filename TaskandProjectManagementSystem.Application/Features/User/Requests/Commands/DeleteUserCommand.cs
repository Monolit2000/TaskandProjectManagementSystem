using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskandProjectManagementSystem.Application.Features.User.Requests.Commands
{
    public class DeleteUserCommand : IRequest<BaseCommandResponse>
    {
        public int Id { get; set; } 
    }
}
