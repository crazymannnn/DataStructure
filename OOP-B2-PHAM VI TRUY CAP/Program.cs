namespace OOP_B2_PHAM_VI_TRUY_CAP
{
    internal class Program
    {
        //static void Main(string[] args)
        //{
        //    var Sv1 = new SinhVien();
        //    Sv1.DiemLy = 10;
        //    Console.WriteLine(Sv1.DiemLy);
        //}

        //class SinhVien {
        //    private string MASV;
        //    private string HoTen;      //private objetc
        //    private double DiemToan;
        //    private double DiemVan;
        //    private double diemLy;

        //    public double DiemLy {
        //        get { return diemLy; }       //cap nhat, thay doi private object
        //        set  { diemLy = value; }
        //    }
        //}

        //class Car {
        //    private string type = "electric";   //private same class is ok
        //    static void Main(string[] args)
        //    {
        //        Car Object = new Car();
        //        Console.WriteLine(Object.type);
        //    }
        //}

        //class outPut
        //{
        //    Car car1 = new Car();       //other class cannot use private object
        //    static void Main(string[] args)
        //    {
        //        Car Object = new Car();
        //        Console.WriteLine(Object.type);
        //    }
        //}

        //property 
        class Person {
            private string name;    //private field
            public string Name {    //property
                get { return name; }   // get & set method
                set { name = value; }

            }
        }

        static void Main(string[] args)     //if dont use get set method we cannot update private object in order classes
        {
            Person myObj = new Person();
            myObj.Name = "Liam";
            Console.WriteLine(myObj.Name);
        }
    }
}
