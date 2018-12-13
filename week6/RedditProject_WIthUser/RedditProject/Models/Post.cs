using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Threading.Tasks;

namespace RedditProject.Models
{
    public class Post
    {
        public Post()
        {
            Frequency = 0;
            Date = DateTime.Now.ToString();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public int Frequency { get; set; }
        public string Date { set; get; }

        public User User { set; get; }
        public int UserId { get; set; }

    }
}
