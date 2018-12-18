using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WareHouseApp.Models
{
    public class Good
    {
        public long GoodId { get; set; }
        public string Name { get; set; }
        public int Stock { get; set; }
    }
}
