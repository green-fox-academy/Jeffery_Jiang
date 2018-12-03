using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GreenFoxApp.Models
{
    public class Fox
    {
        public string Name { set; get; }
        public string Foods { get; set; }
        public List<string> Tricks { set; get; }

        public List<string> ActionRecord { set; get; }

       
    }
}
