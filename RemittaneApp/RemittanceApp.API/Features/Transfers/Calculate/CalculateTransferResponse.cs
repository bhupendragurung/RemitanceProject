namespace RemittanceApp.API.Features.Transfers.Calculate
{
    public record CalculateTransferResponse(
    bool CanTransact,
    decimal ExchangeRate,
    decimal SourceAmount,
    decimal TargetAmount,
    decimal Fee,
    decimal TotalDebit
);
}
