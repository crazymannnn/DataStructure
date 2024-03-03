namespace spojEICREDI2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Reader rd = new Reader();
            var numOfstudent = rd.NextInt();
            var listofstudent = new List<Student>();
            for (int i = 0; i < numOfstudent; i++) {
                var man = new Student
                {
                    Name = rd.Next(),
                    Subject = rd.NextInt(),
                };
                for (int j = 0; j < man.Subject; j++) {
                    man.Score.Add(rd.NextInt());
                }
                listofstudent.Add(man);
            }          
            foreach (var pp in listofstudent) {
                var finalresult = checkScore(pp);
                Console.WriteLine($"{pp.Name} {pp.Score} {finalresult}");
            }
        }

        public static List<int> groupedScore(List<Student> man)

        public static int checkScore(Student man) {
            var passedsubject = man.Score.Count(i => i >= 50);
            var sumscore = (from num in man.Score where num >= 50 select num).Sum();
            return sumscore / passedsubject;
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
