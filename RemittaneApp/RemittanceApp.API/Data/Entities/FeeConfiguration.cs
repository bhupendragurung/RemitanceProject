namespace RemittanceApp.API.Data.Entities
{
    public class FeeConfiguration
    {
        public int Id { get; set; }
        public string Currency { get; set; } = default!;
        public decimal MinAmount { get; set; }
        public decimal MaxAmount { get; set; }
        public decimal FeeAmount { get; set; }
        public bool IsPercentage { get; set; }

    }
}
