namespace Expert.WebShop.vjezbe.Models
{
    public class BuyProducts
    {
        public int Id { get; set; }

        public int ProductId { get; set; }

        public string OrderedByName { get; set; } = null!;

        public string OrderedByEmail { get; set; } = null!;

        public Guid OrderId { get; set; }
        public int NumberOfItems { get; set; }

        public decimal PricePerProduct { get; set; }
        public int ProductDiscount { get; set; }
        public decimal TotalAmmount { get; set; }
        public bool IsPayed { get; set; }
        public bool IsDelivered { get; set; }
    }
}
