using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.ObjectPool;
using RedditProject.Models;
using RedditProject.Services;
using RedditProject.ViewModels;
using X.PagedList;
namespace RedditProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPostServer postServer;
        private readonly IUserServer userServer;

        public HomeController(IPostServer postServer,IUserServer userServer)
        {
            this.postServer = postServer;
            this.userServer = userServer;
        }
        [HttpGet("")]
        public IActionResult Index(string username)
        {
            if (string.IsNullOrEmpty(username))
            {
                return View("LoginPage");
            }
            //var postlist = postServer.FindAll().ToList();
            var user = userServer.FindByName(username);
            var postlist = postServer.FindAll(user.UserId).ToList();
            //if (user is null)
            //{
            //    return View("LogonPage");
            //}
            var viewModel = new UserPostsViewModel()
            {
                PostList = postlist,
                User = user
            };
            return View(viewModel);
        }

       

        [HttpPost("operation")]
        public IActionResult Operation(string userName,int id,string op)
        {
            postServer.RecordDate(id);
            if (op=="plus")
            {
                postServer.PlusPostFre(id);
            }else if (op == "minus")
            {
                postServer.MinusPostFre(id);
            }
            return Redirect($"/?username={userName}");
        }

        [HttpGet("newpost")]
        public IActionResult NewPost(int userId)
        {
            ViewBag.userId = userId;
            return View();
        }

        [HttpPost("newpost")]
        public IActionResult AddPost(Post post)
        {
            postServer.Add(post);
            var user = userServer.FindById(post.UserId);
            return Redirect($"/?username={user.UserName}");
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
