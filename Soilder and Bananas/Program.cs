namespace Soilder_and_Bananas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Reader reader = new Reader();
            var cost = reader.NextInt();
            var money = reader.NextInt();
            var banana = reader.NextInt();
            var sum = 0;
            for (int i = 0; i <= banana; i++) {
                sum = sum + cost * i;
            }
            if (sum <= money)
            {
                Console.WriteLine(0);
            }
            else {
                Console.WriteLine(sum - money);
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
