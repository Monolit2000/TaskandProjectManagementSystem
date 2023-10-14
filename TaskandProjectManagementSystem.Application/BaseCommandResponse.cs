using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskandProjectManagementSystem.Application
{
    public class BaseCommandResponse
    {
        public int id { get; set; }
        public bool Success { get; set;}
        public string Message { get; set; }
    }
}
