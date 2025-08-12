using MediatR;
using RemittanceApp.API.Common;

namespace RemittanceApp.API.Features.Transfers.Calculate
{
    public record CalculateTransferCommand(
      string SourceCurrency,
      string TargetCurrency,
      decimal Amount
  ) : IRequest<ApiResponse< CalculateTransferResponse>>;
}
