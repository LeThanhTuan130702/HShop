namespace Acme.BookStore.Orders;

public enum OrderStatus
{
    New,
    Confirmed,
    Processing,
    Shipping,
    Completed,
    Cancelled,
    Refunded,
}
