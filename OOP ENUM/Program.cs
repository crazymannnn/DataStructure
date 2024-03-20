namespace OOP_Abstract
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Key myAns = Key.yes;    //if using (int) it return index
            Console.WriteLine(myAns);
        }
        enum Key
        {
            yes,
            no,
        }

    }
}
