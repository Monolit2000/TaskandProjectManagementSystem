using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskandProjectManagementSystem.Application.DTOs.UserDTO;

namespace TaskandProjectManagementSystem.Application.Features.User.Requests.Commands
{
    public class UpdateUserCommand : IRequest<BaseCommandResponse>
    {
        public UpdateUserDTO UpdateUserDTO { get; set; }
    }
}
