namespace A._Team
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Reader rd = new Reader();
            int countOfSol = 0;
            int count = 0;
            int n = rd.NextInt();
            int[, ] arr = new int[n,3];
            for (int i = 0; i < n; i++) {
                count = 0;
                for (int j = 0; j < 3; j++)
                {
                    arr[i, j] = rd.NextInt();
                    if (arr[i, j] == 1) {
                        count++;
                    }
                }
                if (count >= 2) {
                    countOfSol++;
                }

            }
            Console.WriteLine(countOfSol);
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
