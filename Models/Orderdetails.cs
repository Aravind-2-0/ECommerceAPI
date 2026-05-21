namespace ECommerceAPI.Models
{
    public class Orderdetails
    {
        public int orderId { get; set; }
        public int productId { get; set; }
        public int customerId { get; set; }
        public string productName { get; set; }
        public string category { get; set; }
        public string region { get; set; }
        public DateTime dateOfSale { get; set; }
        public int quantity { get; set; }
        public int unitPrice { get; set; }
        public int discount { get; set; }
        public int shippingCost { get; set; }
        public string paymentMethod { get; set; }
        public string customerName { get; set; }
        public string customerEmail { get; set; }
        public string customerAddress { get; set; }


    }
}
