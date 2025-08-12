using Microsoft.EntityFrameworkCore;
using RemittanceApp.API.Data.Entities;

namespace RemittanceApp.API.Data.Repositories
{
    public class PayoutTransactionRepository:IPayoutTransactionRepository
    {
        private readonly AppDbContext _context;

        public PayoutTransactionRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<PayoutTransaction?> GetByIdAsync(Guid transactionId)
        {
            return await _context.PayoutTransactions.FindAsync(transactionId);
        }

        public async Task AddAsync(PayoutTransaction transaction)
        {
            await _context.PayoutTransactions.AddAsync(transaction);
            await _context.SaveChangesAsync();
        }
    }
}
