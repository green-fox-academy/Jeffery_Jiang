using System;
using System.Linq;
using FrontEnd;
using Xunit;
using FrontEnd.Models;
using FrontEnd.Controllers;
using Microsoft.EntityFrameworkCore;

namespace FrontEndXunitTestProject
{
    public class FrontControllerUnitTest
    {
        

        //for in-memory dababase
        private static ApplicationContext SetUpApplicationContext()
        {
            var builder= new DbContextOptionsBuilder<ApplicationContext>();
            builder.UseInMemoryDatabase("FrontApiDatabase");
            var context= new ApplicationContext(builder.Options);

            context.AddRange();
            context.SaveChanges();
            return context;
        }
        [Theory]
        [InlineData(5)]
        public void DoublingMethodShouldReturnDoubledResult(int? until)
        {
            // arrange
            var context = SetUpApplicationContext();
            var controller= new FrontController(context);

            //act 
            var result = controller.GetDoubling(until);
            var logList = context.Logs.ToList();

            // assert

            Assert.Equal(10,result.Value.Result);
        }
    }
}
