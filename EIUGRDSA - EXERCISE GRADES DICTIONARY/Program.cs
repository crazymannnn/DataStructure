namespace EIUGRDSA___EXERCISE_GRADES_DICTIONARY
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Reader rd = new Reader();
            var numOfStudent = rd.NextInt();
            var numOfProblem = rd.NextInt();
            var numOfSubmission = rd.NextInt();
            var problemId = new List<int>();
            Dictionary<int, Student> studentMap = new Dictionary<int, Student>();
            for (int i = 0; i < numOfStudent; i++) {
                var student = new Student() { 
                    Id = rd.NextInt(),
                };
                studentMap.Add(student.Id, student);
            }
            for (int i = 0; i < numOfProblem; i++)
            {
                 problemId.Add(rd.NextInt());                 
            }
            for (int i = 0; i < numOfSubmission; i++) {
                var studentId = rd.NextInt();
                var currentStudent = studentMap[studentId];
                var submission = new Submission()
                {
                    Code = rd.NextInt(),
                    Score = rd.NextInt(),
                };
                var check = currentStudent.ScoreMapping.ContainsKey(submission.Code);
                if (!check)
                {
                    currentStudent.ScoreMapping.Add(submission.Code, submission.Score);
                }
                else {
                    var currentscore = currentStudent.ScoreMapping[submission.Code];
                    if (submission.Score > currentscore)
                    {
                        currentStudent.ScoreMapping[submission.Code] = submission.Score;
                    }
                }               
            }

            var students = studentMap.Values.ToList();
            var checkAvr = students
                .OrderBy(x => x.Id)
                .Select(x => new Report() { 
                    Id=x.Id,
                    Avr = Avr(x, numOfProblem),
                })
                .ToList();


            foreach (var pp in checkAvr) {
                Console.WriteLine($"{pp.Id} {pp.Avr}");
            }
        }

        public static int Avr(Student student, int numOfProblem) {
            double sum = 0;
            foreach (var subject in student.ScoreMapping) {
                var value = subject.Value;
                sum = sum + value;
            }
            return (int)sum/numOfProblem;
        }





        public class Report { 
            public int Id { get; set; }
            public int Avr { get; set; }
        }




        public class Student { 
            public int Id { get; set; }
            public List<int> Code = new List<int>();
            public Dictionary<int, int> ScoreMapping = new Dictionary<int, int>();
        }

        public class Submission { 
            public int Code { get; set; }
            public int Score { get; set; }
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
