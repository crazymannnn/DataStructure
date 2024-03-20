namespace EIUGRDSA2___TINH_DIEM_MON_HOC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Reader rd = new Reader();
            var numOfStudent = rd.NextInt();
            var numOfSubject = rd.NextInt();
            var numOfSubmission = rd.NextInt();
            Dictionary<int, Student> studentMap = new Dictionary<int, Student>();
            for (int i = 0; i < numOfStudent; i++) {
                var student = new Student()
                {

                };
            }
        }
    }

    public class Student { 
        public int Id { get; set; }
        public List<int> Code = new List<int>();
        public Dictionary<int, int> ScoreMapping = new Dictionary<int, int>();
    }

    public class Submission
    {
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
