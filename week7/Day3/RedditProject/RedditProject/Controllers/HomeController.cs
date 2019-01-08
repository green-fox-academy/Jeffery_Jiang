using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.ObjectPool;
using RedditProject.Models;
using RedditProject.Services;
using X.PagedList;
namespace RedditProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPostServer postServer;
        public HomeController(IPostServer postServer)
        {
            this.postServer = postServer;
        }

        public async Task<IActionResult> Index(int? page)
        {
            int pageNumber = page ?? 1;
            int pageSize = 10;
            var postlist = await postServer.FindAllAsync();
            return View(postlist.ToPagedList(pageNumber,pageSize));
        }

        [HttpPost("operation")]
        public IActionResult Operation(int id,string op)
        {
            postServer.RecordDate(id);
            if (op=="plus")
            {
                postServer.PlusPostFre(id);
            }else if (op == "minus")
            {
                postServer.MinusPostFre(id);
            }
            return RedirectToAction(nameof(Index));
        }

        [HttpGet("newpost")]
        public async Task<IActionResult> NewPost()
        {
            return View();
        }

        [HttpPost("newpost")]
        public async Task<IActionResult> AddPost(Post post)
        {
            await postServer.AddAsync(post);
            return RedirectToAction(nameof(Index));
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
