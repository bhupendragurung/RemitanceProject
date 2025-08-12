using RemittanceApp.API.Data.Entities;

namespace RemittanceApp.API.Data.Repositories
{
    public interface IWalletRepository
    {
        Task<Wallet> GetWalletByIdAsync(string walletId);
        Task UpdateWallet(Wallet wallet);
    }
}
