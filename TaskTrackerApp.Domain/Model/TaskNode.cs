using TaskTrackerApp.Domain.Enum;

namespace TaskTrackerApp.Domain.Model;

public class TaskNode
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime CreateAt { get; set; }
    public DateTime? DueDate { get; set; }
    public int AssingedUserId { get; set; }
    public TaskNodeStatus NodeStatus { get; set; }
}