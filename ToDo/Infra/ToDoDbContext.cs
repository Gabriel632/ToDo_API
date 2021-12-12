using Microsoft.EntityFrameworkCore;
using ToDo.Application.DTOs;

namespace ToDo.Infra
{
    public class ToDoDbContext : DbContext
    {
        public ToDoDbContext(DbContextOptions<ToDoDbContext> options) : base(options)
        { }

        public DbSet<ToDoListDTO> ToDoList { get; set; }
    }
}
