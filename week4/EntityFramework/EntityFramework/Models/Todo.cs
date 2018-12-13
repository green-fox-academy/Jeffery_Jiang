using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFramework.Models
{
    public class Todo
    {
        public string Title { get; set; }
        public long Id { get; set; }
        public bool IsUrgent { get; set; }
        public bool Isdone { get; set; }

        public Todo()
        {
            IsUrgent = false;
            Isdone = false;
        }
    }
}
