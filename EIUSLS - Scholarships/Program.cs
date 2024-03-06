using System.Security.Cryptography.X509Certificates;

namespace EIUSLS___Scholarships
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Reader rd = new Reader();
            var numOfStudent = rd.NextInt();
            var students = new List<Student>();
            for (int i = 0; i < numOfStudent; i++) {
                var student = new Student()
                {
                    Name = rd.Next(),
                    Subject = rd.NextInt(),
                };
                for (int j = 0; j < student.Subject; j++) {
                    student.Score.Add(rd.NextInt());
                }
                students.Add(student);
            }
        }

        public class List<Student> check(Student student) {
            int max = 0;

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
