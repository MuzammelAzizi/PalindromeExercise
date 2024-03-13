using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("level", true)]
        [InlineData("saga", false)]
        [InlineData("modern", false)]
        [InlineData("test", false)]
        
        public void PalindromeTest(string word, bool expected)
        {
            //Arrange
            // note pre code by instance of a class by method lives 

            var test = new WordSmith();

            //Act calling the method
            var actual = test.IsAPalindrome(word);
            //Assert
            Assert.Equal(expected, actual); 
        }
    }
} 
