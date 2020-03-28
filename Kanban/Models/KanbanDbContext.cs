using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Kanban.Models
{
  public class KanbanContext : DbContext
  {
    public virtual DbSet<Project> Projects { get; set; }
    public DbSet<Manager> Managers { get; set; }
    public DbSet<ToDoList> ToDoLists {get; set;}
    public DbSet<Status> Statuses {get; set;}
    public DbSet<ProjectManager> ProjectManagers { get; set; }
    public KanbanContext(DbContextOptions options) : base(options){}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.Entity<Status>().HasData(
        new Status {StatusId = 1, StatusName = "To-Do",},
        new Status {StatusId = 2, StatusName = "In Progress",},
        new Status {StatusId = 3, StatusName = "Testing",},
        new Status {StatusId = 4, StatusName = "Done",}
        );
    }
  }
}