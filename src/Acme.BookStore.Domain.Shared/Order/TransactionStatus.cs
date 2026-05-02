namespace Acme.BookStore.Orders;

public enum TransactionStatus
{
    ConfirmOrder,
    StartProcessing,
    FinishOrder,
    CancelOrder,
}
