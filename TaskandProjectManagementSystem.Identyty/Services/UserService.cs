using Microsoft.AspNet.Identity;
using TaskandProjectManagementSystem.Identyty.Model;

namespace TaskandProjectManagementSystem.Identyty.Services
{
    public class UserService
    {
        public readonly UserManager<ApplicationUser> _userManeger;

        public UserService(UserManager<ApplicationUser> userManager)
        {
            _userManeger = userManager;
        }
    }
}