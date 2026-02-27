using TaskTrackerApp.Domain.Model;

namespace TaskTrackerApp.Infrastructure.Interface;

public interface ITaskRepository
{
    TaskNode GetTaskById(int id);
    void AddTask(TaskNode task);
    void UpdateTask(TaskNode task);
    void DeleteTask(int id);
    List<TaskNode> GetTasksByUser(int userId);
}