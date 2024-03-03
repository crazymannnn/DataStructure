using System.Security.Cryptography.X509Certificates;

namespace EICREDIT___Tín_chỉ_tích_lũy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Reader rd = new Reader();
            var numStudent = rd.NextInt();
            var liststudents = new List<Person>();

            //nhap input
            for (int i = 0; i < numStudent; i++) {
                var hocsinh = new Person()
                {
                    Name = rd.Next(),
                    Subject = rd.NextInt(),
                };
                for (int a = 0; a < hocsinh.Subject; a++) {
                    hocsinh.Score.Add(rd.NextInt());
                }
                liststudents.Add(hocsinh);
            }
            foreach (var students in liststudents) {
                var result = CalculateCredit(students);
                Console.WriteLine($"{students.Name} {result}");
            }
            

        }

        public static int CalculateCredit(Person hocsinh) {
            var totalPassSubject = hocsinh.Score.Count(i => i >= 50);
            var totalCredit = totalPassSubject * 4;
            return totalCredit;
        }


        public class Person { 
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
