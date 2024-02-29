using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
namespace spoj.EIDUPBOD
{
    internal class Program //duy
    {
        static void Main(string[] args)
        {
            Reader reader = new Reader();
            var student = reader.NextInt();
            var dayofbirth = new List<Dob>();
            //nhap input
            for (int i = 0; i < student; i++) {
                var dob = new Dob()
                {
                    Date = reader.NextInt(),
                    Month = reader.NextInt(),
                    Year = reader.NextInt(),
                };
                dayofbirth.Add(dob);
                
            }
            var check = dayofbirth
                .GroupBy(x => new { x.Date, x.Month, x.Year })
                .Select(x => x)
                .OrderBy(x => x.Key.Year)
                .ThenBy(x => x.Key.Month)
                .ThenBy(x => x.Key.Date)
                .ToList();

            foreach (var people in check) {
                //if (people.Key.Month < 10 && people.Key.Date < 10)
                //{
                //    Console.WriteLine($"0{people.Key.Date}/0{people.Key.Month}/{people.Key.Year} {people.Count()}");
                //}
                //else if (people.Key.Month >= 10 && people.Key.Date < 10)
                //{
                //    Console.WriteLine($"0{people.Key.Date}/{people.Key.Month}/{people.Key.Year} {people.Count()}");
                //}
                //else if (people.Key.Month < 10 && people.Key.Date >= 10)
                //{
                //    Console.WriteLine($"{people.Key.Date}/0{people.Key.Month}/{people.Key.Year} {people.Count()}");
                //}
                //else {
                //    Console.WriteLine($"{people.Key.Date}/{people.Key.Month}/{people.Key.Year} {people.Count()}");
                //}
                var date = people.Key.Date.ToString();
                if (people.Key.Date < 10) {
                    date = $"0{date}";
                }
                var month = people.Key.Month.ToString();
                if (people.Key.Month < 10) {
                    month = $"0{month}";
                }
                Console.WriteLine($"{date}/{month}/{people.Key.Year} {people.Count()}");                                                   
            }
        }


        public class Dob {
            public int Date { get; set; }
            public int Month { get; set; }
            public int Year { get; set; }
        }


        class Reader
        {
            private int index = 0;
            private string[] tokens;
            public string Next()
            {
                while (tokens == null || tokens.Length <= index)
                {
                    tokens = Console.ReadLine().Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                    index = 0;
                }
                return tokens[index++];
            }
            public int NextInt()
            {
                return int.Parse(Next());
            }

            public double NextDouble()
            {
                return double.Parse(Next());
            }
        }
    }
}
