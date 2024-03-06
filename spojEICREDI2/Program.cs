
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace spojEICREDI2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Reader rd = new Reader();
            var numOfstudent = rd.NextInt();
            var students = new List<Student>();
            for (int i = 0; i < numOfstudent; i++)
            {
                var man = new Student()
                {
                    Name = rd.Next(),
                    Subject = rd.NextInt(),
                };
                for (int j = 0; j < man.Subject; j++)
                {
                    var score = rd.NextInt();
                    if (score >= 50)
                    {
                        man.Score.Add(score);
                    }
                }
                students.Add(man);
            }
            var builder = new StringBuilder();

            var finalresult = check(students);
            foreach (var man in finalresult) {
                builder.Append($"{man.Name} ");
                foreach (var pp in man.Score) {
                    builder.Append($"{pp} ");
                }
                builder.Append($"{man.Avr}\n");
            }
            Console.WriteLine( builder.ToString() );
        }

        public class Report {
            public string Name { get; set; }
            public List<int> Score { get; set; } = new List<int>();
            public double Avr { get; set; }
        }

        public static List<Report> check(List<Student> students) {
            var result = students
                .Select(i => new Report() { 
                    Name = i.Name,
                    Score = i.Score,
                    Avr = Avr(i)
                })
                .ToList();
            return result;
        }

        public static int Avr(Student man) {
            if (man.Score.Count() == 0) {
                return 0;
            }
            int avr = (int)(man.Score.Average());
            return avr;
        }
        

        public class Student { 
            public string Name { get; set; }
            public int Subject { get; set; }
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
