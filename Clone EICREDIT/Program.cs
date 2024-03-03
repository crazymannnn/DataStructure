namespace Clone_EICREDIT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Reader rd = new Reader();
            var numOfstudents = rd.NextInt();
            var liststudent = new List<People>();
            for (int i = 0; i < numOfstudents; i++) {
                var pp = new People
                {
                    Name = rd.Next(),
                    Subject = rd.NextInt(),
                };
                for (int j = 0; j < pp.Subject; j++) {
                    pp.Score.Add(rd.NextInt());
                }
                liststudent.Add(pp);
            }
            foreach (var human in liststudent) {
                var finalresult = checkCredit(human);
                Console.WriteLine($"{human.Name} {finalresult}");
            }

        }

        public static int checkCredit(People pp) {
            var credit = pp.Score.Count(i => i >= 50);
            var result = credit * 4;
            return result;
        }

        public class People {
            public string Name { get; set; }
            public int Subject { get; set; }
            public List<int> Score {get; set;} = new List<int>();
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
