using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqLibrary
{
    public class ListManager
    {
        public static List<Person> LoadSampleData()
        {
            List<Person> output = new List<Person>();

            output.Add(new Person { FirstName = "Tim", LastName = "Corey", Birthday = Convert.ToDateTime("1970-02-25"), YearsExperience = 20 });
            output.Add(new Person { FirstName = "Joe", LastName = "Smith", Birthday = Convert.ToDateTime("1970-03-31"), YearsExperience = 12 });
            output.Add(new Person { FirstName = "Sue", LastName = "Storm", Birthday = Convert.ToDateTime("1970-03-01"), YearsExperience = 1 });
            output.Add(new Person { FirstName = "Sara", LastName = "Jones", Birthday = Convert.ToDateTime("1970-06-03"), YearsExperience = 8 });
            output.Add(new Person { FirstName = "Jamie", LastName = "Doe", Birthday = Convert.ToDateTime("1970-02-18"), YearsExperience = 7 });
            output.Add(new Person { FirstName = "Mary", LastName = "Smith", Birthday = Convert.ToDateTime("1970-01-23"), YearsExperience = 16 });

            return output;
        }
    }
}
