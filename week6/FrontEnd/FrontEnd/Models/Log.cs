using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrontEnd.Models
{
    public class Log
    {
        public long Id { get; set; }
        public string CreateAt { get; set; }
        public string EndPoint { get; set; }
        public string Data { get; set; }
        public Log()
        {
            CreateAt = DateTime.Now.ToString();
        }
    }
}
