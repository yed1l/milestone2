using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ToDoTaskApp.Models
{
    public class ToDoTaskAppContext : DbContext
    {
        public ToDoTaskAppContext (DbContextOptions<ToDoTaskAppContext> options)
            : base(options)
        {
        }

        public DbSet<ToDoTaskApp.Models.Task> Task { get; set; }
    }
}
