namespace Next_Round
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Reader rd = new Reader();
            int n = rd.NextInt();
            int k = rd.NextInt();
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = rd.NextInt();
            }
            int aws = countOfPeo(k, arr);
            Console.WriteLine(aws);

        }
        public static int countOfPeo(int k, int[] arr) {
            int count = 0;
            for (int i = 0; i < arr.Length; i++) { 
                if (arr[i] > 0 && arr[i] >= arr[k-1]) {
                    count++;
                }
            }
            return count;
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
