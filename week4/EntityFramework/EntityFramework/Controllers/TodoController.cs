using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EntityFramework.Models;
using Microsoft.AspNetCore.Mvc;

namespace EntityFramework.Controllers
{
    public class TodoController : Controller
    {
        private readonly ApplicationContext applicationContext;

        public TodoController(ApplicationContext applicationContext)
        {
            this.applicationContext = applicationContext;
        }
        [HttpGet("/todo")]
        [HttpGet("/todo/list")]
        public IActionResult List(bool isActive)
        {
            IQueryable<Todo> todos = applicationContext.Todos;
            if (isActive is true)
            {
                todos = todos.Where(t => !t.Isdone);
            }
            

            
            return View(todos.ToList());
        }

        [HttpPost("/add")]
        public IActionResult AddTodo(Todo todo)
        {
            applicationContext.Todos.Add(todo);
            applicationContext.SaveChanges();
            return Redirect("/");
        }
    }
}