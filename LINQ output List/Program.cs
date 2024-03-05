using System.Security.Cryptography.X509Certificates;

namespace linq3._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Reader rd = new Reader();
            var numOfStudent = rd.NextInt();
            var targetScore = rd.NextInt();
            var numOfSubject = rd.NextInt();
            var students = new List<Person>();
            for (int i = 0; i < numOfStudent; i++) {
                var human = new Person {
                    Name = rd.Next(),
                };
                for (int j = 0; j < numOfSubject; j++) {
                    human.Score.Add(rd.NextInt());
                }
                students.Add(human);
            }

            var finalresult = check(students, targetScore);
            foreach (var man in finalresult) {
                Console.WriteLine($"{man.Name} {man.Numofpassed}");
            }
        }

        public static List<Report> check(List<Person> students, int targetScore) {
            var result = students
                .Select(x => new Report()
                {
                    Name = x.Name,
                    Numofpassed = x.Score.Count(i => i >= targetScore),
                })
                .ToList();
            return result;
        }

        public class Report { 
            public string Name { get; set; }
            public int Numofpassed { get; set; }
        }

        public class Person {
            public string Name { get; set; }
            public List<int> Score { get; set; } = new List<int>();
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
