using TaskTrackerApp.Domain.Model;
using TaskTrackerApp.Infrastructure.Interface;

namespace TaskTrackerApp.Infrastructure.Repository;

public class FirebaseTaskRepository: ITaskRepository
{
    public TaskNode GetTaskById(int id)
    {
        throw new NotImplementedException();
    }

    public void AddTask(TaskNode task)
    {
        throw new NotImplementedException();
    }

    public void UpdateTask(TaskNode task)
    {
        throw new NotImplementedException();
    }

    public void DeleteTask(int id)
    {
        throw new NotImplementedException();
    }

    public List<TaskNode> GetTasksByUser(int userId)
    {
        throw new NotImplementedException();
    }
}