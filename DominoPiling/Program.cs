namespace DominoPiling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Reader rd = new Reader();
            int n = rd.NextInt();
            int m = rd.NextInt();
            Console.WriteLine((n * m) / 2);

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
