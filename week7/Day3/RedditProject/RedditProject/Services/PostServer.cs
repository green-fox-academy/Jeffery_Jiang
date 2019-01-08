using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RedditProject.Models;
using X.PagedList;

namespace RedditProject.Services
{
    public class PostServer:IPostServer
    {
        private readonly ApplicationContext applicationContext;
        public PostServer(ApplicationContext applicationContext)
        {
            this.applicationContext = applicationContext;
        }

        public async Task<IEnumerable<Post>> FindAllAsync()
        {
            return  await applicationContext.Posts
                .OrderByDescending(r=>r.Frequency).ToListAsync();
        }

        public async Task AddAsync(Post post)
        {
            await applicationContext.Posts.AddAsync(post);
            await applicationContext.SaveChangesAsync();
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
