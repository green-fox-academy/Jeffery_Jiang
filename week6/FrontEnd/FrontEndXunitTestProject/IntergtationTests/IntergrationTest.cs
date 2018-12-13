using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using FrontEnd;
using FrontEnd.Controllers;
using Microsoft.AspNetCore.Mvc.Testing;
using Newtonsoft.Json;
using Xunit;

namespace FrontEndXunitTestProject.IntergtationTests
{
    public class IntergrationTest : IClassFixture<WebApplicationFactory<Startup>>
    {
        private readonly WebApplicationFactory<Startup> factory;
        public IntergrationTest(WebApplicationFactory<Startup> factory)
        {
            this.factory = factory;
        }

        [Theory]
        [InlineData("some")]
        public async Task AppendaMethodAppendSuccsesfully1(string foo)
        {
            //arrange
            var client =  factory.CreateClient();

            //act
            var responseMessage = await client.GetAsync($"/appenda/{foo}");
            var content = await responseMessage.Content.ReadAsStringAsync();
            var result =  JsonConvert.DeserializeObject<FrontController.Appender>(content);

            //assert
            Assert.Equal("somea",result.Appended);
        }

        [Theory]
        [InlineData("some messages")]
        [InlineData("I am Happy")]
        public async Task Groottask(string message)
        {
            var client = factory.CreateClient();

            var responseMessage = await client.GetAsync($"/groot?message={message}");
            var content = await responseMessage.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<RespondMessage>(content);

            Assert.Equal("I am Groot!",result.Teanslated);
            Assert.Equal("I am Groot!", result.Teanslated);
        }
        [Theory]
        [InlineData(100,10)]
        [InlineData(100,0)]
        public async Task ArrowSpeedCalculationShouldReturnSuccsesful(double distance, double time)
        {
            var client = factory.CreateClient();

            var responseMessage = await client.GetAsync($"/yondu?distance={distance}&time={time}");
            var content = await responseMessage.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<ArrowInformation>(content);

            Assert.Equal(10,result.Speed);
            Assert.Null(result.Speed);
        }
    }
}
