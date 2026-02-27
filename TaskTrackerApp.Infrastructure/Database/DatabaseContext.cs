using Microsoft.EntityFrameworkCore;
using TaskTrackerApp.Domain.Enum;
using TaskTrackerApp.Domain.Model;

namespace TaskTrackerApp.Infrastructure.DataBase;

public class DatabaseContext(DbContextOptions<DatabaseContext> options) : DbContext(options)
{
    public DbSet<TaskNode> TaskNodes { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Project> Roles { get; set; }
}