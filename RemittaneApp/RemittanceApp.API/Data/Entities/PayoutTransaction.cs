namespace RemittanceApp.API.Data.Entities
{
    public class PayoutTransaction
    {
        public Guid TransactionId { get; set; }
        public string SourceWalletId { get; set; } = default!;
        public string DestinationAccountNumber { get; set; } = default!;
        public string BankCode { get; set; } = default!;
        public string Country { get; set; } = default!;

        public decimal SourceAmount { get; set; }
        public string SourceCurrency { get; set; } = default!;
        public decimal TargetAmount { get; set; }
        public string TargetCurrency { get; set; } = default!;
        public decimal ExchangeRate { get; set; }
        public decimal Fee { get; set; }

        public string Status { get; set; } = "Pending"; // Pending, Completed, Failed
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public Wallet SourceWallet { get; set; } = default!;
    
}
}
