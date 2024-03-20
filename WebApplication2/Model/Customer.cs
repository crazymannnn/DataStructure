namespace WebApplication2.Model
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<ProductInCart> Cart { get; set; }
        public Customer(int id, string name, List<ProductInCart> cart) {
            this.Id = id;
            this.Name = name;
            this.Cart = cart;
        }

    }
}
