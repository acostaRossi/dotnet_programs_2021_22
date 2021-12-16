using System.Collections.Generic;

namespace ListDataStructure
{
    public partial class Form1
    {
        public class Seeder {
            public static List<Person> GetPeople()
            {
                return new List<Person>()
                {
                    new Person() { Name = "John", Age = 25 },
                    new Person() { Name = "Maria", Age = 38 },
                    new Person() { Name = "Bob", Age = 41 },
                    new Person() { Name = "Anita", Age = 71 },
                    new Person() { Name = "Vanessa", Age = 18 },
                    new Person() { Name = "Arnold", Age = 67 }
                };
            }
        }
    }
}
