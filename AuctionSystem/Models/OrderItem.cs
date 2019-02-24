namespace AuctionSystem.Models
{
    public class OrderItem
    {
        public int OrderItemID { get; set; }
        public int OrderID { get; set; }
        public int AuctionID { get; set; }
        public int Amount { get; set; }
        public decimal BuyoutPrice { get; set; }

        public virtual Auction Auction { get; set; }
        public virtual Order Order { get; set; }
    }
}