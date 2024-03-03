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
                Console.WriteLine("0");
            }
            char[] ss1 = (s1.ToLower()).ToCharArray();
            char[] ss2 = (s2.ToLower()).ToCharArray();
            int count1 = 0;
            int count2 = 0;
            for (int i = 0; i < s1.Length; i++) {
                count1 = count1 + ss1[i];
            }
            for (int i = 0; i < s2.Length; i++)
            {
                count2 = count2 + ss2[i];
            }
            if (count1 > count2) {
                Console.WriteLine("1");
            }
            if (count1 < count2) { 
                Console.WriteLine("-1");
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
