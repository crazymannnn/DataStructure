namespace OOP_Tinh_Da_Hinh
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal Cat = new Cat();  //phai overide
            Animal Dog = new Dog();
            Cat.Speak();
            Dog.Speak();
        }

        class Animal {
            public virtual void Speak() {   //abstract
                Console.WriteLine("Animal is speaking...");
            }
        }

        class Cat: Animal
        {
            public override void Speak()
            {
                Console.WriteLine("Cat is speaking...");
            }
        }

        class Dog: Animal
        {
            public override void Speak()
            {
                Console.WriteLine("Dog is speaking...");
            }
        }
    }
}
