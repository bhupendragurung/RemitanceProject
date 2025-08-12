using FluentValidation;

namespace RemittanceApp.API.Features.Transfers.Calculate
{
    public class CalculateTransferValidator: AbstractValidator<CalculateTransferCommand>
    {
        private static readonly HashSet<(string Source, string Target)> SupportedPairs = new()
    {
        ("GBP", "USD"),
        ("USD", "EUR") 
    };
        public CalculateTransferValidator()
        {
            RuleFor(x => x.SourceCurrency).NotEmpty().Length(3);
            RuleFor(x => x.TargetCurrency).NotEmpty().Length(3);
            RuleFor(x => x.Amount).GreaterThan(0);
            RuleFor(x => x)
           .Must(pair => SupportedPairs.Contains((pair.SourceCurrency, pair.TargetCurrency)))
           .WithMessage(cmd =>
               $"Currency pair {cmd.SourceCurrency} → {cmd.TargetCurrency} is not supported."
           );
        }
    }
}
