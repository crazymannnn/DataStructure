namespace CART
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            var user = new User()
            {
                Name = "Duy",
                History = new List<Order>(),
                Cart = new List<ProductOrder>(),
            };
            var product = new Product()
            {
                Id = 123,
                Name = "Laptop",
                Price = 100,
            };
            var product1 = new Product()
            {
                Id = 123,
                Name = "Laptop",
                Price = 100,
            };
            var product2 = new Product()
            {
                Id = 1234,
                Name = "Laptop1",
                Price = 100,
            };
            var final = SelectProduct(user, product, n);
            final = SelectProduct(user, product, n);
            final = SelectProduct(user, product2, n);
            foreach (var thing in final) {
                Console.WriteLine($"{thing.Product.Name} {thing.Quantity}");
            }
        }

        public static List<ProductOrder> SelectProduct(User user, Product product, int quantity) {
            var productorder = new ProductOrder()
            {
                Product = product,
                Quantity = quantity,
            };
            var isExitsted = false;
            foreach (var productInCart in user.Cart) {
                if (product.Id == productInCart.Product.Id)
                {
                    isExitsted = true;
                    productInCart.Quantity = productInCart.Quantity + quantity;
                    break;
                }                             
            }
            if (!isExitsted)
            {
                user.Cart.Add(productorder);
            }
            return user.Cart;
        }

        public class Product { 
            public int Id { get; set; }
            public string Name { get; set; }
            public string Category { get; set; }
            public int Price { get; set; }
        }

        public class User { 
            public string Name { get; set; }
            public string Address { get; set; }
            public string PhoneNumber { get; set; }
            public List<Order> History { get; set; }
            public List<ProductOrder> Cart { get; set; }
        }

        public class Order 
        {
            public string Id { get; set; }
            public List<ProductOrder> ProductsOrder { get; set; }
            public Payment Payment { get; set; }
            public DateTime TimeOrder { get; set; }
            
        }

        public class Payment {
            public string ID { get; set; }
            public Boolean IsPaid { get; set; }
            public List<Voucher> Vouchers { get; set; }
            public int FinalPrice { get; set; }
            public int InitialPrice { get; set; }
            public int SalePrice { get; set; }
        }

        public class ProductOrder 
        {
            public Product Product { get; set; }
            public int Quantity { get; set; }
        }

        public class Voucher { 
            public string ID { get; set; }
            public int SalePercent { get; set; }
        }

    }
}
