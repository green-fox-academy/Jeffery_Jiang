using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RedditProject.Models;

namespace RedditProject.Services
{
    public interface IUserServer
    {
        User FindById(int id);
        void AddUser(string name);
        User FindByName(string name);
    }
}
