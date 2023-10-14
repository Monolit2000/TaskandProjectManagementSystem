using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskandProjectManagementSystem.Application.Model.Identity;

namespace TaskandProjectManagementSystem.Application.Contracts.Identyty
{
    public interface IAuthService
    {
        Task<AuthResponce> Login(AuthRequest request);

        Task<RegistrationResponse> Registration(RegistrationRequest request);
    }
}
