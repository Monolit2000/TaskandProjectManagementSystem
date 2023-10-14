using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskandProjectManagementSystem.Domain;

namespace TaskandProjectManagementSystem.Application.DTOs.Projects
{
    public class ProjectDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public List<TaskProd> Tasks { get; set; }
        public User Manager { get; set; }
    }
}
