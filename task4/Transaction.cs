namespace task4;

public class Transaction
{
    public int id { get; set;}
    public DateTime dateTime { get; set;}
    public decimal amount { get; set; }
    public TransactionType transactionType { get; set; }
}