using Algorithms;
using Xunit;
namespace AlgorithmsTest
{
    public class RomantoIntegerTest
    {
        [Theory]
        [InlineData("DCXXI", 621)]
        [InlineData("XXXIV", 34)]
        [InlineData("MCMXCVI", 1996)]
        public void TestMethod(string s, int output)
        {
            Assert.Equal(output, Solution013.RomanToInt(s));
        }
    }
}

