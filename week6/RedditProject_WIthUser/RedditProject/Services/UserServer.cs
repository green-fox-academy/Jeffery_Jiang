using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RedditProject.Models;

namespace RedditProject.Services
{
    public class UserServer:IUserServer
    {
        private readonly ApplicationContext applicationContext;

        public UserServer(ApplicationContext applicationContext)
        {
            this.applicationContext = applicationContext;
        }

        public User FindById(int id)
        {
            return applicationContext.Users.Find(id);
        }

        public User FindByName(string name)
        {
            var user = applicationContext.Users.FirstOrDefault(u => u.UserName == name);
            return user;
        }

        public void AddUser(string name)
        {
            var checkUser = applicationContext.Users.Find(name);
            if (checkUser is null)
            {
                var user = new User()
                {
                    UserName = name
                };
                applicationContext.Users.Add(user);
                applicationContext.SaveChanges();
            }
            else
            {
                throw new ArgumentException("Username Already Exist");
            }
        }
    }
}
