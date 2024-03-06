namespace Clone_Girl_Hoc_Bong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var students = new List<Student>() {
                new Student() {
                    Name = "Duy",
                    Gender = Gender.Male,
                    Scores = new List<int> {50, 60, 70 },
                },
                new Student() {
                    Name = "Cuong",
                    Gender = Gender.Male,
                    Scores = new List<int> {90, 90, 95},
                },
                new Student() {
                    Name = "Xuan",
                    Gender = Gender.Female,
                    Scores = new List<int> {90, 95, 95},
                },
                new Student() {
                    Name = "Thu",
                    Gender = Gender.Female,
                    Scores = new List<int> {80, 80, 80},
                },
                new Student() {
                    Name = "ko hoc",
                    Gender = Gender.Female,
                    Scores = new List<int> {},
                },
            };

            var finalResult = Reports(students);
            foreach (var man in finalResult) {
                Console.WriteLine($"{man.Name} {man.Payment} {man.SalePayment} {man.RealPayment}");
            }
        }

        public static double Payment(Student student) {
            if (student.Scores.Count() == 0)
            {
                return 0;
            }
            var sumOfPayment = 1500 * student.Scores.Count();
            var avr = student.Scores.Average();
            if (student.Gender == Gender.Female) {
                if (avr >= 90)
                {
                    return 0;
                }
                else if (avr >= 85)
                {
                    return sumOfPayment * 0.8;
                }
                else if (avr >= 80) {
                    return sumOfPayment * 0.5;
                }               
            }
            return sumOfPayment;           
        }

        public static List<Report> Reports(List<Student> students ) {
            var result = students
                .Select(i => new Report()
                {
                    Name = i.Name,
                    Payment = 1500 * i.Scores.Count(),
                    SalePayment = 1500 * i.Scores.Count() - Payment(i),
                    RealPayment = Payment(i),
                })
                .ToList();
            return result;
        }



        public class Report { 
            public string Name { get; set; }
            public double Payment { get; set; }
            public double SalePayment { get; set; }
            public double RealPayment { get; set; }
        }

        public class Student { 
            public string Name { get; set; }
            public List<int> Scores { get; set; }
            public Gender Gender { get; set; }
        }

        public enum Gender { 
            Male,
            Female,
            Other,
        }
    }
}
