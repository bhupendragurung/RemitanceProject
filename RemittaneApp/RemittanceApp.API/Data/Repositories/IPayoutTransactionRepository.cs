using RemittanceApp.API.Data.Entities;

namespace RemittanceApp.API.Data.Repositories
{
    public interface IPayoutTransactionRepository
    {
        Task<PayoutTransaction?> GetByIdAsync(Guid transactionId);
        Task AddAsync(PayoutTransaction transaction);
    }
}
