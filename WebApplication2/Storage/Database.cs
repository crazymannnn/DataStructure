using WebApplication2.Model;

namespace WebApplication2.Storage
{
    public class Database
    {
        public static List<Customer> Customers = new List<Customer>()
        {
            new Customer(1, "duy", new List<ProductInCart>()),
            new Customer(2, "toan", new List<ProductInCart>()),
            new Customer(3, "diep", new List<ProductInCart>()),
            new Customer(4, "lin", new List<ProductInCart>()),
        };

        public static List<Product> Products = new List<Product>() {
            new Product() {
                Id = 1,
                Name = "hat",
                Price = 100,
            },
            new Product() {
                Id = 2,
                Name = "banana",
                Price = 10,
            },
            new Product() {
                Id = 3,
                Name = "tivi",
                Price = 150,
            },
            new Product() {
                Id = 4,
                Name = "sofa",
                Price = 250,
            }
        };
    }
}
