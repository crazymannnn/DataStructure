using WebApplication2.Model;

namespace WebApplication2.Services
{
    public class CartService
    {
        public static bool AddToCart(int idCustomer, int idProduct ) {
            var customers = Storage.Database.Customers;
            var currentCustomer = customers
                .FirstOrDefault(x => x.Id == idCustomer);
            if (currentCustomer == null) {
                return false;
            }
            var products = Storage.Database.Products;
            var currentProduct = products
                .FirstOrDefault(x => x.Id == idProduct);
            var currentCart = currentCustomer.Cart;
            var product = currentCart.FirstOrDefault(i => i.Id == idProduct);
            if (product == null)
            {
                var newProduct = new ProductInCart()
                {
                    Id = idProduct,
                    Quantity = 1,
                };
                currentCart.Add(newProduct);
            }
            else {
                product.Quantity++;
            }
            return true;
        }
    }
}
