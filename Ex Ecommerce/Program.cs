using System.Runtime.InteropServices.Marshalling;

namespace Ex_Ecommerce
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Reader rd = new Reader();
            Boolean flag = true;
            Boolean inOut = false;
            var acc = rd.Next();
            var pass = rd.Next();
            while (flag == true)
            {
                while (inOut == false)
                {
                    Console.WriteLine("Enter your username:");
                    var account = rd.Next();
                    Console.WriteLine("Enter your password");
                    var passWord = rd.Next();
                    if (account == acc && passWord == pass)
                    {
                        inOut = true;
                    }
                    else { 
                        Console.WriteLine("Try again!");
                    }
                }
                var ans = 0;
                while (ans != 3)
                {
                    Console.WriteLine("What do you want to do?\n" +
                        "[1]Add things to your cart\n" +
                        "[2]Delete things in your cart\n" +
                        "[3]Log out");
                    ans = rd.NextInt();
                    if (ans == 1)
                    {
                        Console.WriteLine("How many things do you want to add in your cart?");
                        var quantity = rd.NextInt();
                        Console.WriteLine("Added successfully " +quantity+" things");
                    }
                    else if (ans == 2)
                    {
                        Console.WriteLine("How many things do you want to delete from your cart?");
                        var deleted = rd.NextInt();
                        Console.WriteLine("Deleted successfully " + deleted+ " things");
                    }
                    else if (ans == 3)
                    {
                        flag = false;
                        Console.WriteLine("Log out successfully");
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
}
