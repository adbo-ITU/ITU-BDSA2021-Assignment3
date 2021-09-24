using System;
using Xunit;

namespace BDSA2020.Assignment03.Tests
{
    public class QueriesTests
    {
        [Fact]
        public void RowlingWizards_returns_harry_and_dumbledore()
        {
            var withExtensions = Queries.GetRowlingWizards_WithExtensions();
            var withLinq = Queries.GetRowlingWizards_WithVeryLinq();

            var expectedNames = new[] { "Dumbledore", "Harry Potter" };
            Assert.Equal(expectedNames, withExtensions);
            Assert.Equal(expectedNames, withLinq);
        }
    }
}
