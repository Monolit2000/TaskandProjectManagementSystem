﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskАndProjectManagementSystem.Application.Project;
using TaskАndProjectManagementSystem.Domain;

namespace TaskАndProjectManagementSystem.Application.User
{
    public class CreateUserDTO
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public List<ProjectDTO> Projects { get; set; }
    }
}
