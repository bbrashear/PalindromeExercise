using System;
using Xunit;
using PalindromeExercise;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("kayak", true)]
        [InlineData("civic", true)]
        [InlineData("hello", false)]
        [InlineData("world", false)]
        [InlineData("great", false)]
         
        public void PalindromeTester(string word, bool expected)
        {
            //Arrange
            var sut = new Palindrome();

            //Act
            var actual = sut.IsAPalindrome(word);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
