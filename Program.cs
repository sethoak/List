using System;
using System.Collections.Generic;

namespace ListIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> cohorts = new List<int>();

            cohorts.Add(34);
            cohorts.Add(35);
            cohorts.Add(36);
            cohorts.Add(37);

            //another way to initialize the list(as a string and not a INT)
            List<string> classes = new List<string>()
            {
                "Cohort 34",
                "Cohort 35",
                "Cohort 36",
                "Cohort 37"
            };

            classes.Remove("Cohort 34");
            classes.Add("Cohort 38");
            //item is a variable
            foreach (string nssClass in classes)
            {
                Console.WriteLine(nssClass);
            }
        }
    }
}
