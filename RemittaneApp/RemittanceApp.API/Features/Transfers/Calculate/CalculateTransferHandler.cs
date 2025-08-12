using MediatR;
using RemittanceApp.API.Common;

namespace RemittanceApp.API.Features.Transfers.Calculate
{
    public class CalculateTransferHandler : IRequestHandler<CalculateTransferCommand, ApiResponse<CalculateTransferResponse>>
    {
        public async Task<ApiResponse<CalculateTransferResponse>> Handle(CalculateTransferCommand request, CancellationToken cancellationToken)
        {
          decimal exchangeRate = 1.30m; 
            decimal targetAmount = request.Amount * exchangeRate;

            // Fee rules
            decimal fee = request.Amount <= 50 ? 1.99m : 0m;
            decimal totalDebit = request.Amount + fee;

            var result= new CalculateTransferResponse(
                true,
                exchangeRate,
                request.Amount,
                targetAmount,
                fee,
                totalDebit
            );
            return ApiResponse<CalculateTransferResponse>.SuccessResponse("Calculate success", result);
        }
    }
}
