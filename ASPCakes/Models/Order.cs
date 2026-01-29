namespace ASPCakes.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int CustomersId { get; set; }
        public Customer Customers { get; set; }
        public int ProductsId { get; set; }
        public Product Products { get; set; }
        public int Quantity { get; set; }
        public DateTime RegisterOn { get; set; }

    }
}
