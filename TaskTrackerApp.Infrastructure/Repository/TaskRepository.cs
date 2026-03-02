using Microsoft.EntityFrameworkCore;
using TaskTrackerApp.Domain.Model;
using TaskTrackerApp.Infrastructure.DataBase;
using TaskTrackerApp.Infrastructure.Interface;

namespace TaskTrackerApp.Infrastructure.Repository;

public class TaskRepository: ITaskRepository
{
    private readonly DatabaseContext _context;

    public TaskRepository(DatabaseContext context)
    {
        _context = context;
    }

    public void AddTask(TaskNode taskNode)
    {
        _context.TaskNodes.Add(taskNode);
        _context.SaveChanges();
    }

    public TaskNode GetTaskById(int id)
    {
        return _context.TaskNodes.FirstOrDefault(t => t.Id == id);
    }

    public List<TaskNode> GetTasksByUser(int userId)
    {
        return _context.TaskNodes.Where(t => t.AssingedUserId == userId).ToList();
    }

    public void UpdateTask(TaskNode taskNode)
    {
        _context.TaskNodes.Update(taskNode);
        _context.SaveChanges();
    }

    public void DeleteTask(int id)
    {
        var task = _context.TaskNodes.FirstOrDefault(t => t.Id == id);
        if (task != null)
        {
            _context.TaskNodes.Remove(task);
            _context.SaveChanges();
        }
    }
}