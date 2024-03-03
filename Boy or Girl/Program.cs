namespace Boy_or_Girl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Reader rd = new Reader();
            string s = rd.Next();
            char[] s1 = s.ToCharArray();
            int count = 1;
            for (int i = 1; i < s.Length; i++)
            {
                if (s1[0] != s1[i])
                {
                    count++;
                }
            }
            int j;
            for (int i = 1; i < s.Length; i++)
            {
                for (j = i + 1; j < s.Length; j++)
                {
                    if (s1[i] == s1[j])
                    {
                        count--;
                    }
                }
            }
            if (count % 2 == 0)
            {
                Console.WriteLine("CHAT WITH HER!");
            }
            else
            {
                Console.WriteLine("IGNORE HIM!");
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