using System.Collections.Generic;
using System.Linq;
using System;

namespace BDSA2020.Assignment03
{
    public class Queries
    {
        public static IEnumerable<string> GetRowlingWizards_WithExtensions()
        {
            var wizards = Wizard.Wizards.Value;
            return wizards.Where(w => w.Creator == "J. K. Rowling").Select(w => w.Name);
        }

        public static IEnumerable<string> GetRowlingWizards_WithVeryLinq()
        {
            var wizards = Wizard.Wizards.Value;
            return from w in wizards
                   where w.Creator == "J. K. Rowling"
                   select w.Name;
        }

        public static int? FirstSithLordYear_WithExtensions()
        {
            var wizards = Wizard.Wizards.Value;
            return wizards.Where(w => w.Name.StartsWith("Darth")).Select(w => w.Year).Min();
        }

        public static int? FirstSithLordYear_WithVeryLinq()
        {
            var wizards = Wizard.Wizards.Value;
            var years = from w in wizards
                        where w.Name.StartsWith("Darth")
                        select w.Year;
            return years.Min();
        }

        public static IEnumerable<(string, int?)> HarryPotterUnique_WithExtensions()
        {
            var wizards = Wizard.Wizards.Value;

            return wizards
                .Where(w => w.Medium.Contains("Harry Potter"))
                .Select(w => (w.Name, w.Year))
                .Distinct();
        }

        public static IEnumerable<(string, int?)> HarryPotterUnique_WithVeryLinq()
        {
            var wizards = Wizard.Wizards.Value;
            var tuples = from w in wizards
                         where w.Medium.Contains("Harry Potter")
                         select (w.Name, w.Year);
            return tuples.Distinct();
        }

        public static IEnumerable<string> NamesReverseByCreatorThenName_WithExtensions()
        {
            var wizards = Wizard.Wizards.Value;
            return wizards
                .OrderByDescending(w => w.Creator)
                .ThenBy(w => w.Name)
                .Select(w => w.Name);
        }

        public static IEnumerable<string> NamesReverseByCreatorThenName_WithVeryLinq()
        {
            var wizards = Wizard.Wizards.Value;

            return from w in wizards
                   orderby w.Creator descending, w.Name ascending
                   select w.Name;
        }
    }
}
