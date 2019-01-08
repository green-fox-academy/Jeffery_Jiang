using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RedditProject.Models;

namespace RedditProject.Services
{
    public interface IPostServer
    {
        Task<IEnumerable<Post>> FindAllAsync();
        Task AddAsync(Post post);
        void Remove(int id);
        void PlusPostFre(int id);
        void MinusPostFre(int id);
        void RecordDate(int id);
    }
}
