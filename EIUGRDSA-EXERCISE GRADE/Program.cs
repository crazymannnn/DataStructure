using System.Dynamic;

namespace EIUGRDSA_EXERCISE_GRADE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Reader rd = new Reader();
            var numOfStudent = rd.NextInt();
            var numOfProblem = rd.NextInt();
            var numOfSubmission = rd.NextInt();
            List<int> problemIDs = new List<int>();
            Dictionary<int, Student> studentMap = new Dictionary<int, Student>();
            while (numOfStudent != 0) { 
                var studentID = rd.NextInt();
                var student = new Student()
                {
                    Id = studentID
                };
                studentMap.Add(studentID, student);
                numOfStudent--;
            }
            while (numOfProblem != 0) {
                problemIDs.Add(rd.NextInt());
                numOfProblem--;
            }
            while (numOfSubmission != 0) {
                var studentID = rd.NextInt();
                var submission = new Submission()
                {
                    Code = rd.NextInt(),
                    Score = rd.NextInt(),
                };
                var currentStudent = studentMap[studentID];
                currentStudent.Submissions.Add(submission);
            }
        }

        

        public class Submission { 
            public int Code { get; set; }
            public int Score { get; set; }
        }

        public class Student { 
            public int Id { get; set; }
            public List<Submission> Submissions { get; set; } = new List<Submission>();
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
