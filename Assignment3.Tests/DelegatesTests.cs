using System;
using System.Linq;
using Xunit;

namespace BDSA2020.Assignment03.Tests
{
    public class DelegatesTests
    {
        [Theory]
        [InlineData("abc", "cba")]
        [InlineData("", "")]
        [InlineData("s", "s")]
        [InlineData("this string is a bit longer", "regnol tib a si gnirts siht")]
        public void String_reverse_works(string input, string expectedOutput)
        {
            Func<string, string> reverser = (inp) => new string(inp.Reverse().ToArray());
            var reversed = reverser(input);
            Assert.Equal(expectedOutput, reversed);
        }

        [Theory]
        [InlineData(2.0, 2.0, 4.0)]
        [InlineData(-2.5, 3.0, -7.5)]
        public void Decimal_product_works(decimal x, decimal y, decimal expectedOutput)
        {
            Func<decimal, decimal, decimal> multiplier = (x, y) => x * y;
            var product = multiplier(x, y);
            Assert.Equal(expectedOutput, product);
        }

        [Theory]
        [InlineData(42, "0042")]
        [InlineData(-123, " -0123")]
        public void Numerically_equal_works(int x, string xString)
        {
            Func<int, string, bool> isNumericallyEqual = (x, xString) => x == Int32.Parse(xString);
            var equal = isNumericallyEqual(x, xString);
            Assert.True(equal);
        }
    }
}
