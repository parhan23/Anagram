using Microsoft.VisualStudio.TestTools.UnitTesting;
using Anagram;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestGetWordLength()
        {
            string input = "Hello world! It's a test string";
            int[] expected = { 5, 5, 0, 2, 4, 6 };
            int[] received =
            {
                AnBuilder.GetWordLength(input, 0),
                AnBuilder.GetWordLength(input, 6),
                AnBuilder.GetWordLength(input, 17),
                AnBuilder.GetWordLength(input, 13),
                AnBuilder.GetWordLength(input, 20),
                AnBuilder.GetWordLength(input, 25),
            };

            // Comparing expected and received arrays
            for (int i = 0; i != expected.Length; ++i)
                if (expected[i] != received[i])
                    Assert.Fail();
        }

        [TestMethod]
        public void TestSwapChars()
        {
            char[] input = "Text for the Swap Chars method".ToCharArray();
            char[][] expected =
            {
                "Text rof the Swap Chars method".ToCharArray(),
                "Text for the Cwap Shars method".ToCharArray(),
                "Text for the Swap C arshmethod".ToCharArray()
            };
            char[][] received = new char[expected.Length][];

            // Received array initialization
            for (int i = 0; i != expected.Length; ++i)
            {
                received[i] = new char[expected[i].Length];
                input.CopyTo(received[i], 0);
            }
            AnBuilder.SwapChars(ref received[0], 5, 7);
            AnBuilder.SwapChars(ref received[1], 13, 18);
            AnBuilder.SwapChars(ref received[2], 19, 23);

            // Comparing expected and received arrays
            for (int i = 0; i != expected.Length; ++i)
            {
                for (int j = 0; j != expected[i].Length; ++j)
                if (expected[i][j] != received[i][j])
                    Assert.Fail();
            }
        }
    }
}
