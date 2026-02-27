using TaskTrackerApp.Domain.Model;
using TaskTrackerApp.Infrastructure.Interface;

namespace TaskTrackerApp.Application.Services;

public class TaskService
{
    private readonly ITaskRepository _taskRepository;

    public TaskService(ITaskRepository taskRepository)
    {
        _taskRepository = taskRepository;
    }

    public void CreateTask(TaskNode taskNode)
    {
        _taskRepository.AddTask(taskNode);
    }

    public List<TaskNode> GetTasksForUser(int userId)
    {
        return _taskRepository.GetTasksByUser(userId);
    }

    public void UpdateTask(TaskNode taskNode)
    {
        _taskRepository.UpdateTask(taskNode);
    }

    public void DeleteTask(int taskId)
    {
        _taskRepository.DeleteTask(taskId);
    }
}