namespace Petya_and_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Reader rd = new Reader();
            string s1 = rd.Next();
            string s2 = rd.Next();
            if (s1.ToLower() == s2.ToLower()) {
                Console.WriteLine(0);
            }
            char[] ss1 = (s1.ToLower()).ToCharArray();
            char[] ss2 = (s2.ToLower()).ToCharArray();
            if (ss1[s1.Length - 1] < ss2[s2.Length - 1]) { 
                Console.WriteLine(-1);
            }
            if (ss1[s1.Length - 1] > ss2[s2.Length - 1])
            {
                Console.WriteLine(1);
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
