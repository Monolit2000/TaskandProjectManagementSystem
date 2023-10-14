using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace TaskandProjectManagementSystem.Application.Features.User.Requests.Commands
{
    public class CreateUserCommand : IRequest<BaseCommandResponse>
    {
        public int Id {  get; set; }
    }
}
