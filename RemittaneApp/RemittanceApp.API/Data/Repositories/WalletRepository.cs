using RemittanceApp.API.Data.Entities;

namespace RemittanceApp.API.Data.Repositories
{
    public class WalletRepository:IWalletRepository
    {
        private readonly AppDbContext _context;

        public WalletRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Wallet> GetWalletByIdAsync(string walletId)
        {
            return await _context.Wallets.FindAsync(walletId);
        }

        public async Task UpdateWallet(Wallet wallet)
        {
            _context.Wallets.Update(wallet);
            await _context.SaveChangesAsync();
        }
    }
}
