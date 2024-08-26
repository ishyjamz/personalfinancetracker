namespace FinanceAppBackend.Models;

public class Transaction
{
    public int Id { get; set; }

    public string Merchant { get; set; }

    public bool isOutgoing { get; set; }

    public Category Category { get; set; }

    public decimal Amount { get; set; }
    
    public Account Account { get; set; }
}