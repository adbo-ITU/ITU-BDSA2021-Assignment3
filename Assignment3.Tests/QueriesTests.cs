using System;
using Xunit;
using System.Collections.Generic;

namespace BDSA2020.Assignment03.Tests
{
    public class QueriesTests
    {
        [Fact]
        public void RowlingWizards_returns_harry_harry_dumbledore_and_moody()
        {
            var withExtensions = Queries.GetRowlingWizards_WithExtensions();
            var withLinq = Queries.GetRowlingWizards_WithVeryLinq();

            var expectedNames = new[] { "Harry Potter", "Harry Potter", "Dumbledore", "Alastor Moody" };
            Assert.Equal(expectedNames, withExtensions);
            Assert.Equal(expectedNames, withLinq);
        }

        [Fact]
        public void FirstSithLordYear_returns_1977()
        {
            var withExtensions = Queries.FirstSithLordYear_WithExtensions();
            var withLinq = Queries.FirstSithLordYear_WithVeryLinq();

            var expectedYear = 1977;
            Assert.Equal(expectedYear, withExtensions);
            Assert.Equal(expectedYear, withLinq);
        }

        [Fact]
        public void HarryPotterUnique_returns_harry_dumbledore_moody_with_year()
        {
            var withExtensions = Queries.HarryPotterUnique_WithExtensions();
            var withLinq = Queries.HarryPotterUnique_WithVeryLinq();

            var expectedPairs = new (string, int?)[] {
                ("Harry Potter", 1997),
                ("Dumbledore", 1997),
                ("Alastor Moody", 2005),
            };
            Assert.Equal(expectedPairs, withExtensions);
            Assert.Equal(expectedPairs, withLinq);
        }

        [Fact]
        public void NamesReverseByCreatorThenName_returns_correct()
        {
            var withExtensions = Queries.NamesReverseByCreatorThenName_WithExtensions();
            var withLinq = Queries.NamesReverseByCreatorThenName_WithVeryLinq();

            IEnumerable<string> expectedNames = new[] {
                "Alex Russo",

                "Doctor Strange",

                "Tara",
                "Willow",

                "Merlin",

                "Gandalf",
                "Sauron",

                "Alastor Moody",
                "Dumbledore",
                "Harry Potter",
                "Harry Potter",

                "Darth Maul",
                "Darth Sidious",
                "Darth Vader",
                "Yoda",

                "The White Witch",
            };
            Assert.Equal(expectedNames, withExtensions);
            Assert.Equal(expectedNames, withLinq);
        }
    }
}
