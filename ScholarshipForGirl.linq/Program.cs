namespace ScholarshipForGirl.linq
{
    internal class Program
    {
        static void Main(string[] args)
        {           
            var students = new List<Student>() {
                new Student() {
                    Name = "Duy",
                    gender = Gender.Male,
                    Score = new List<int> {50, 60, 70 },
                },
                new Student() {
                    Name = "Cuong",
                    gender = Gender.Male,
                    Score = new List<int> {90, 90, 95},
                },
                new Student() {
                    Name = "Xuan",
                    gender = Gender.Female,
                    Score = new List<int> {90, 95, 95},
                },
                new Student() {
                    Name = "Thu",
                    gender = Gender.Female,
                    Score = new List<int> {80, 80, 80},
                },
                new Student() {
                    Name = "ko hoc",
                    gender = Gender.Female,
                    Score = new List<int> {},
                },
            };

            var final = check(students);
            foreach (var man in final) {
                Console.WriteLine($"{man.Name} {man.Payment} {man.DiscountPayment} {man.FinalPayment}");
            }
            
        }


        public static List<Report> check(List<Student> students) {
            var finalresult = students
                .Select(i => new Report()
                {
                    Name = i.Name,
                    Payment = 1500 * i.Score.Count,
                    DiscountPayment = 1500 * i.Score.Count - Payment(i),
                    FinalPayment = Payment(i)
                })
                .ToList();
            return finalresult;
        }

        public class Report { 
            public string Name { get; set; }
            public double Payment { get; set; }
            public double DiscountPayment { get; set; }
            public double FinalPayment { get; set; }
        }
        public static double Payment(Student student) {
            var count = student.Score.Count;
            if (count == 0)
            {
                return 0;
            }
            var avr = student.Score.Average();
            double sumOfPayment = 1500 * student.Score.Count();
            if (student.gender == Gender.Female) {
                if (avr >= 90)
                {
                    return 0;
                }
                else if (avr >= 85)
                {
                    return sumOfPayment * 0.8;
                }
                else if (avr >= 80)
                {
                    return sumOfPayment * 0.5;
                }
            }
            return sumOfPayment;
             
        }



        public enum Gender { 
            Male,
            Female,
            Other
        }

        public class Student { 
            public string Name { get; set; }
            public Gender gender { get; set; }
            public List<int> Score { get; set; } = new List<int>();
        }
    }
}
