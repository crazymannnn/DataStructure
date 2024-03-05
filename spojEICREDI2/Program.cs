using System.Security.Cryptography.X509Certificates;

namespace spojEICREDI2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Reader rd = new Reader();
            var numOfstudent = rd.NextInt();
            var listofstudent = new List<Student>();
            var scores = new List<int>();
            for (int i = 0; i < numOfstudent; i++) {
                var man = new Student()
                {
                    Name = rd.Next(),
                    Subject = rd.NextInt(),
                };
                for (int j = 0; j < man.Subject; j++) { 
                    var score = rd.NextInt();
                    if (score >= 50) {
                        man.Score.Add(score);
                        scores.Add(score);
                    }
                }
                listofstudent.Add(man);
            }
            foreach (var name in listofstudent) {
                Console.Write($"{name.Name}");
            }
        }

        public static int avrScore(Student man) { 
            var sum = man.Score.Sum();
            var num = man.Score.Count(x => x >= 50);
            return sum / num;
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
