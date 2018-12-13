using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RedditProject.Models;

namespace RedditProject.Services
{
    public class PostServer : IPostServer
    {
        private readonly ApplicationContext applicationContext;
        public PostServer(ApplicationContext applicationContext)
        {
            this.applicationContext = applicationContext;
        }

        public IEnumerable<Post> FindAll(int userId)
        {
            return applicationContext.Posts
                .Where(p => p.UserId == userId)
                .Include(p => p.User);

        }

        public void Add(Post post)
        {
            applicationContext.Posts.Add(post);
            applicationContext.SaveChanges();
        }

        public void Remove(int id)
        {
            var @post = applicationContext.Posts.Find(id);
            applicationContext.Posts.Remove(@post);
            applicationContext.SaveChanges();
        }

        public void PlusPostFre(int id)
        {
            var @post = applicationContext.Posts.Find(id);
            @post.Frequency += 1;
            applicationContext.SaveChanges();
        }

        public void MinusPostFre(int id)
        {
            var @post = applicationContext.Posts.Find(id);
            @post.Frequency -= 1;
            applicationContext.SaveChanges();
        }

        public void RecordDate(int id)
        {
            var @post = applicationContext.Posts.Find(id);
            @post.Date = DateTime.Now.ToString();
            applicationContext.SaveChanges();
        }
    }
}
