using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskandProjectManagementSystem.Domain;

namespace TaskandProjectManagementSystem.Application.DTOs.UserDTO
{
    public class CreateUserDTO
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public List<Project> Projects { get; set; }
    }
}
