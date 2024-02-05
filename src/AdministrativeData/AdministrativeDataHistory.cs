namespace OrderHistory
{
    public record AdministrativeDataHistory
    {
        public string AdministrativeDataHistoryId { get; init; } = "";
        public string CustomerId { get; init; } = "";
        public string OrderDate { get; init; } = "";
        public string OrderTotal { get; init; } = "";
        public string OrderStatus { get; init; } = "";
        public List<OrderItems> OrderItems { get; init; } = new List<OrderItems>();
    }
}