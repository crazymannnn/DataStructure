namespace CloneEIUUPBOD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Reader rd = new Reader();
            var students = rd.NextInt();
            var listdob = new List<Dob>();
            for (int i = 0; i < students; i++) {
                var dob = new Dob()
                {
                    Date = rd.NextInt(),
                    Month = rd.NextInt(),
                    Year = rd.NextInt(),
                };
                listdob.Add(dob);
            }
            var check = listdob
                .GroupBy(x => new { x.Date, x.Month, x.Year })
                .Select(x => x)
                .OrderBy(x => x.Key.Year)
                .ThenBy(x => x.Key.Month)
                .ThenBy(x => x.Key.Date)
                .ToList();

            foreach (var day in check) {
                var date = day.Key.Date.ToString();
                var month = day.Key.Month.ToString();
                if (day.Key.Date < 10) {
                    date = 0 + date;
                }
                if (day.Key.Month < 10)
                {
                    month = 0 + month;
                }
                Console.WriteLine($"{date}/{month}/{day.Key.Year} {day.Count()}");
            }

        }

        public class Dob {
            public int Date { get; set; }
            public int Month { get; set; }
            public int Year { get; set; }
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
