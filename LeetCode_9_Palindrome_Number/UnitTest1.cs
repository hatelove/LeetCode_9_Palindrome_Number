using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode_9_Palindrome_Number
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void x_length_is_1_should_be_palindrome()
        {
            ShouldBePalindrome(5);
        }

        [TestMethod]
        public void x_is_55_should_be_palindrome()
        {
            ShouldBePalindrome(55);
        }

        private static void ShouldBePalindrome(int x)
        {
            Assert.IsTrue(new Solution().IsPalindrome(x));
        }
    }

    public class Solution
    {
        public bool IsPalindrome(int x)
        {
            var charArray = x.ToString().ToCharArray();
            return charArray.Length == 1;
        }
    }
}