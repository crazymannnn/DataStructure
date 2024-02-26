namespace Aton_and_Danik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Reader reader = new Reader();
            var n = reader.NextInt();
            var s = reader.Next();
            var aton = 0;
            for (int i = 0; i < n; i++) {
                if (s[i] == 'A') {
                    aton++;
                } 
            }
            var danik = n - aton;
            if (aton > danik) {
                Console.WriteLine("Anton");
            } else if (aton < danik) {
                Console.WriteLine("Danik");
            } else {
                Console.WriteLine("Friendship");
            }
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
