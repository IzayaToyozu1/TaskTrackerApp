using TaskTrackerApp.Domain.Model;

namespace TaskTrackerApp.Application.Interface;

public interface IProjectRepository
{
    Project GetProjectById(int id);
    void AddProject(Project project);
    void UpdateProject(Project project);
    void DeleteProject(int id);
}