namespace RemittanceApp.API.Data.Entities
{
    public class Wallet
    {
        public string WalletId { get; set; } = default!;
        public string Currency { get; set; } = default!;
        public decimal Balance { get; set; }
        public string UserId { get; set; } = default!;
        public List<PayoutTransaction> Payouts { get; set; } = new();
    }
}
