namespace EIGRADU_GRADUATION
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Reader rd = new Reader();
            int numOfstudent = rd.NextInt();
            int neededCredit = rd.NextInt();
            var students = new List<Student>();
            for (int i = 0; i < numOfstudent; i++)
            {
                var student = new Student()
                {
                    Id = rd.NextInt(),
                    Name = rd.Next(),
                    Subject = rd.NextInt(),
                };
                for (int j = 0; j < student.Subject; j++)
                {
                    var score = rd.NextInt();
                    if (score >= 50)
                    {
                        student.Score.Add(score);
                    }

                }
                students.Add(student);
            }
            var finalResult = Reports(students, neededCredit);
            foreach (var people in finalResult)
            {
                Console.WriteLine($"{people.Id} {people.Name} {people.Avr}");
            }
        }
        public static int calculateNumOfCredit(Student student) {
            var credit = student.Score.Count(x => x >= 50) * 4;
            return credit;
        }

        

        public static List<Report> Reports(List<Student> student, int neededCredit) {
            var check = student
                .Select(x => new Report()
                {
                    Id = x.Id,
                    Name = x.Name,
                    Avr = (int)x.Score
                        .Where(i => i >= 50)
                        .ToList()
                        .Average(),
                    Credit = calculateNumOfCredit(x),
                })
                .Where(x => x.Credit >= neededCredit)
                .OrderByDescending(x => x.Avr)
                .ThenBy(x => x.Id)
                .ToList();
            return check;
        }

        public class Report { 
            public int Id { get; set; }
            public string Name { get; set; }
            public int Avr { get; set; }
            public int Credit { get; set; }
        }

        public class Student { 
            public int Id { get; set; }
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
