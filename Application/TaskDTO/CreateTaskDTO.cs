using TaskАndProjectManagementSystem.Application.User;
using TaskАndProjectManagementSystem.Domain;
using TaskStatus = TaskАndProjectManagementSystem.Domain.TaskStatus;

namespace TaskАndProjectManagementSystem.Application;
public class CreateTaskDTO
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public DateTime Deadline { get; set; }
    public TaskStatus Status { get; set; }
    public Priority Priority { get; set; }
    public List<Comment>? Comments { get; set; }
    public UserDTO? AssignedUser { get; set; }
}
