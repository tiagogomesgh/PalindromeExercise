using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("hello", false)]
        public void Test1(string word, bool expected)
        {
            //arrange
            var tester = new WordSmith();
            //act
            var actual = tester.IsAPalidrome(word);
            //assert
            Assert.Equal(expected, actual);
        }
    }
}
