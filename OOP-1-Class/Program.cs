namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal Dog = new Animal();
            Dog.Weight = 1;  //gan gtri cho cac thuoc tinh
            Dog.Height = 100;   //using "." to call
            Dog.Info();   //call method
            Animal Cat = new Animal(2, 100); //using constructor
            Cat.Info();
        }


        public class Animal {   //class Animal gom 2 thuoc tinh W H va 1 ham` Info
            public double Weight;
            public double Height;
            public Animal(double w, double h) {
                Weight = w;
                Height = h;
            }

            public void Info() {
                Console.WriteLine("Height: " + Height + " Weight: " + Weight);
            }
        }
    }
}
