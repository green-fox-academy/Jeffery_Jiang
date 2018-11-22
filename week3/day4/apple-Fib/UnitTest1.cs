using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using ConsoleApp1;
using Xunit;

namespace AppleTestUnit
{
    
    public class UnitTest1
    {

        [Fact]
        public void TestAppleShouldReturnApple()
        {
            // arrange
            var exceptOutputString = "apple";
            ClassForTest Apple= new ClassForTest();

            //Act
            var result = Apple.GetApple();

            // assert
            Assert.Equal(exceptOutputString,result);
        }

        [Fact]
        public void TestSumShouldReturnTheSumForEmpty()
        {
            //arrange 
            var exceptSum = 0;
            
            List<int> numList=new List<int>();
            
            ClassForTest Sum=new ClassForTest();
            
            // act
            var result = Sum.Sum(numList);

            //assert
            Assert.Equal(exceptSum,result);
        }
        [Fact]
        public void TestSumShouldReturnTheSumForOneElement()
        {
            //arrange 
            var element = 1;
            var exceptSum = element;

            List<int> numList = new List<int>(){element};

            ClassForTest Sum = new ClassForTest();

            // act
            var result = Sum.Sum(numList);

            //assert
            Assert.Equal(exceptSum, result);
        }
        [Fact]
        public void TestSumShouldReturnTheSumForMutipleElements()
        {
            //arrange 
            var exceptSum = 6;

            List<int> numList = new List<int>(){1,2,3};

            ClassForTest Sum = new ClassForTest();

            // act
            var result = Sum.Sum(numList);

            //assert
            Assert.Equal(exceptSum, result);
        }
        [Fact]
        public void TestSumShouldReturnTheSumForNull()
        {
            ClassForTest classForTest=new ClassForTest();
            
            Assert.Null(classForTest.Sum(null));
            
        }

        [Theory]
        [InlineData("apple","ppale")]
        [InlineData("a pple","pp a le")]
        [InlineData("","")]
        //[InlineData(null,null)]
        [InlineData("true lady", "adultery")]
        public void TestIsAnagrameShouldTrue(string str1, string str2)
        {
            ClassForTest classForTest=new ClassForTest();
            Assert.True(classForTest.IsAnagrame(str1,str2));
        }
        [Theory]
        [InlineData("aabbccdd")]
        [InlineData(" aa bb cc dd")]
        [InlineData("aa?!bb.!cc!!dd")]
       // [InlineData()]
        public void TestUnitForCountLetterFunction(string source)
        {
            Dictionary<char,int> expectOutput=new Dictionary<char, int>(){{'a',2},{'b',2},{'c',2},{'d',2} };


            ClassForTest classForTest=new ClassForTest();
            
            Assert.Equal(expectOutput,classForTest.CountLetters(source));
        }
    }
}
