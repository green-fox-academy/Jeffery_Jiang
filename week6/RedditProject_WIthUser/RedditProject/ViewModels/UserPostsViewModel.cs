using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RedditProject.Models;

namespace RedditProject.ViewModels
{
    public class UserPostsViewModel
    {
        public User User { get; set; }
        public List<Post> PostList { get; set; }
}
}
