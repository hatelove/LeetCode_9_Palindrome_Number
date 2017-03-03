using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode_9_Palindrome_Number
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void x_length_is_1_should_be_palindrome()
        {
            var x = 5;
            Assert.IsTrue(new Solution().IsPalindrome(x));
        }
    }

    public class Solution
    {
        public bool IsPalindrome(int x)
        {
            throw new NotImplementedException();
        }
    }
}