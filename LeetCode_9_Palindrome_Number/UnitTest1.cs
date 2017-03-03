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

        [TestMethod]
        public void x_is_56_should_be_not_palindrome()
        {
            ShouldBeNotPalindrome(56);
        }

        [TestMethod]
        public void x_is_676_should_be_palindrome()
        {
            ShouldBePalindrome(676);
        }

        [TestMethod]
        public void x_is_678_should_be_not_palindrome()
        {
            ShouldBeNotPalindrome(678);
        }

        private void ShouldBeNotPalindrome(int x)
        {
            Assert.IsFalse(new Solution().IsPalindrome(x));
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

            if (charArray.Length == 1) return true;

            var start = 0;
            var end = charArray.Length - 1;
            while (start < end)
            {
                if (charArray[start] != charArray[end])
                {
                    return false;
                }

                start++;
                end--;
            }

            return true;
        }
    }
}