using Xunit;

namespace BDSA2020.Assignment03.Tests
{
    public class WizardTests
    {
        [Fact]
        public void Wizards_contains_12_wizards()
        {
            var wizards = Wizard.Wizards.Value;

            Assert.Equal(15, wizards.Count);
        }

        [Theory]
        [InlineData("Darth Vader", "Star Wars: A New Hope", 1977, "George Lucas")]
        [InlineData("Sauron", "The Fellowship of the Ring", 1954, "J.R.R. Tolkien")]
        [InlineData("Willow", "Buffy the Vampire Slayer", 1997, "Joss Whedon")]
        [InlineData("Harry Potter", "Harry Potter and the Philosopher's Stone", 1997, "J. K. Rowling")]
        public void Spot_check_wizards(string name, string medium, int year, string creator)
        {
            var wizards = Wizard.Wizards.Value;

            Assert.Contains(wizards, w =>
                w.Name == name &&
                w.Medium == medium &&
                w.Year == year &&
                w.Creator == creator
            );
        }
    }
}

