namespace LINQ_Product_ID_NAME_PRICE
{
    internal class Program //duy
    {
        static void Main(string[] args)
        {
            Reader reader = new Reader();
            int start = reader.NextInt();
            int end = reader.NextInt();
            var youwant = reader.Next();
            var product1 = new Product()
            {
                Id = "94831",
                Price = 15000,
                Name = "meat chicken",
                Kind = "meat",
                Quantity = 10,
            };
            var product2 = new Product()
            {
                Id = "29316",
                Price = 20000,
                Name = "water sugar",
                Kind = "water",
                Quantity = 20,
            };
            var product3 = new Product() { 
                Id = "23014",
                Price = 30000,
                Name = "meat duck",
                Kind = "meat",
                Quantity = 30,
            };
            var product4 = new Product() {
                Id = "23132",
                Price = 40000,
                Name = "water drink",
                Kind = "water",
                Quantity = 40,
            };

            var giohang = new List<Product>();
            giohang.Add(product1);
            giohang.Add(product2);
            giohang.Add(product3);
            giohang.Add(product4);

            var finalresult = FindTheRemaindingQuantity(giohang);
            foreach (var stuff in finalresult) {
                Console.WriteLine($"{stuff.Kind}: {stuff.Quantity}");
            }
            

            //for (int i = 0; i < productfound.Count(); i++) {
            //    sum = sum + productfound[i].Quantity;
            //}

        }


        public static List<Report> FindTheRemaindingQuantity(List<Product> giohang) {
            var result = giohang
                .GroupBy(i => i.Kind)
                .Select(i => new Report()
                {
                    Kind = i.Key,
                    Quantity = i.Sum(x => x.Quantity),
                })
                .ToList();
            return result;
        }

        public class Report {
            public string Kind { get; set; }
            public int Quantity { get; set; }
        }

        public class Product { 
            public string Id { get; set; }
            public int Price { get; set; }
            public string Name { get; set; }
            public string Kind { get; set; }
            public int Quantity { get; set; }
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
