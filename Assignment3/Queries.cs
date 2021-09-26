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

        // public static int FirstSithLordYear_WithExtensions()
        // {
        //     // TODO
        //     throw new Exception();
        // }

        // public static int FirstSithLordYear_WithVeryLinq()
        // {
        //     // TODO
        //     throw new Exception();
        // }

        // public static IEnumerable<(string, int)> HarryPotterUnique_WithExtensions()
        // {
        //     // TODO
        //     throw new Exception();
        // }

        // public static IEnumerable<(string, int)> HarryPotterUnique_WithVeryLinq()
        // {
        //     // TODO
        //     throw new Exception();
        // }
    }
}
