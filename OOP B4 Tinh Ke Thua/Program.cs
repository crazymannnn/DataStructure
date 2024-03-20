namespace OOP_B3_STATIC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // class <ten lop con>: <ten lop cha>

            var BlackCat = new Cat();
            BlackCat.Info();
        }
        class Animal {
            protected double Weight;
            protected double Height;
            protected static int Legs;

            public void Info() {
                Console.WriteLine(Weight + " " + Height + " " + Legs);
            }
        }

        class Cat : Animal {   //Cat ke thua cac thuoc tinh tu Animal
            public Cat() {
                Weight = 50;
                Height = 30;    //thuoc tinh protected nen khong can khai bao
                Legs = 40;      //private ke thua khong dc
            }
        }
    }
}
