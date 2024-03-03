using System.Security.Cryptography;

namespace LINQex //duy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Person1 = new Person()
            {
                Name = "Duy",
                Age = 20,
            };
            var Person2 = new Person() {
                Name = "Diep",
                Age = 21,
            };
            var Person3 = new Person() {
                Name = "Kinh",
                Age = 22,
            };
            var Person4 = new Person()
            {
                Name = "Toan",
                Age = 22,
            };

            var resident = new List<Person>();
            resident.Add(Person1);
            resident.Add(Person2);
            resident.Add(Person3);
            resident.Add(Person4);

            int k = 22;
            int count = 0;
            var sort = resident.OrderBy(Age => Age.Age).ToList();
            var agegroup = resident.GroupBy(Age => Age.Age).ToList();
            var sort1 = resident.Contains(33);

            //how to get element after using groupby c#
            for (int i = 0; i < 4; i++) {
                if (sort[i].Age == k)
                {
                    count++;
                }
            }
            if (count > 0)
            {
                Console.WriteLine("Yes");
            }
            else {
                Console.WriteLine("No");
            }           
        }


        public class Person {
            public string Name { get; set; }
            public int Age { get; set; }
        }
        
            
        }
    }

