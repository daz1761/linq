using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqLibrary;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = ListManager.LoadSampleData();

            // lets list out ALL of the data from the mock table
            foreach (var person in people)
            {
                Console.WriteLine($"{person.FirstName} {person.LastName} ({person.Birthday.ToShortDateString()}): Experience { person.YearsExperience}");
            }
            Console.WriteLine("");

            // ordering
            List<Person> people2 = ListManager.LoadSampleData();
            // "x" represents a Person object - think of this as a foreach
            people2 = people2.OrderBy(x => x.LastName).ToList();  // we need ToList() because Orderby() returns an IEnumerable

            foreach (var person in people2)
            {
                Console.WriteLine($"{person.FirstName} {person.LastName} ({person.Birthday.ToShortDateString()}): Experience { person.YearsExperience}");
            }
            Console.WriteLine("");

            // order by descending - we can also chain Linq queries
            List<Person> people3 = ListManager.LoadSampleData();
            people3 = people3.OrderByDescending(x => x.LastName).ThenByDescending(x => x.YearsExperience).ToList();

            foreach (var person in people2)
            {
                Console.WriteLine($"{person.FirstName} {person.LastName} ({person.Birthday.ToShortDateString()}): Experience { person.YearsExperience}");
            }
            Console.WriteLine("");

            // filter our list
            List<Person> people4 = ListManager.LoadSampleData();
            people4 = people4.Where(x => x.YearsExperience > 9 && x.Birthday.Month == 3).ToList(); // where clause has to have a comparison (i.e. IF statement)

            foreach (var person in people4)
            {
                Console.WriteLine($"{person.FirstName} {person.LastName} ({person.Birthday.ToShortDateString()}): Experience { person.YearsExperience}");
            }
            Console.WriteLine("");

            // sum the total years
            int yearsTotal = 0;

            yearsTotal = people.Where(x => x.Birthday.Month == 3).Sum(x => x.YearsExperience); // give us all the people who have a month of 3, and sum their years experience up - look at the CHAINING

            Console.WriteLine($"The total years experience is {yearsTotal}");
            Console.WriteLine("");

            Console.ReadLine();
        }
    }
}
