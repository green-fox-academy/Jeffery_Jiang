using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedditProject.Models
{
    public class User
    {
        public string UserName { get; set; }
        public int UserId { get; set; }

        public ICollection<Post> Posts { set; get; }
    }
}
