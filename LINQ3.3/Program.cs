namespace LINQ3._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Reader rd = new Reader();
            var numOfstudents = rd.NextInt();
            var numOfSubject = rd.NextInt();
            var students = new List<Student>();
            var countA = 0;
            var countB = 0;
            var countC = 0;
            for (int i = 0; i < numOfstudents; i++) {
                var people = new Student {
                    Name = rd.Next(),
                };
                for (int j = 0; j < numOfSubject; j++) {
                    people.Score.Add(rd.NextInt());
                }
                students.Add(people);
            }
            foreach (var people in students) { 
                var avrg = AverageScore(people);
                if (avrg >= 90)
                {
                    countA++;
                }
                else if (avrg >= 80)
                {
                    countB++;
                }
                else {
                    countC++;
                }
            }
            Dictionary<string, int> grade = new();
            grade.Add("Grade A:", countA);
            grade.Add("Grade B:", countB);
            grade.Add("Grade C:", countC);
            foreach (var (key, value) in grade) {
                Console.Write($"{key} {value}");               
            }

            foreach (var man in students) {
                var result = AverageScore(man);
                Console.WriteLine($"{man.Name} - {result}");
            }



        }

        public static double AverageScore(Student people) {
            var average = people.Score.Average();
            return average;
        }    

        public class Student { 
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
