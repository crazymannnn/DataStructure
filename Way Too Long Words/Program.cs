using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

namespace Way_Too_Long_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Reader reader = new Reader();
            int n = reader.NextInt();
            string[] arr = new string[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = reader.Next();
            }
            Console.WriteLine(OutPut( arr));
        }
        public static string OutPut(string[] arr) {
            for (int i = 0; i < arr.Length; i++)
            {
                int count = arr[i].Length;
                if (arr[i].Length <= 10)
                {
                    Console.WriteLine(arr[i].ToLower());
                }
                if (arr[i].Length > 10)
                {
                    string first = arr[i][0].ToString();
                    string last = arr[i][count - 1].ToString();
                    return (first.ToLower() + (count - 2) + last.ToLower());
                }
            }
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
