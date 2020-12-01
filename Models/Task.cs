using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoTaskApp.Models
{
    public class Task
    {
        public int TaskId { get; set; }
        public String TaskTitle { get; set; }
        public String TaskComment { get; set; }
        public DateTime TaskDate { get; set; }
        public String TaskStatus { get; set; }

    }
}
