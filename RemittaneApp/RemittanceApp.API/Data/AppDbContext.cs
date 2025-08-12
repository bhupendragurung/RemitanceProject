using Microsoft.EntityFrameworkCore;
using RemittanceApp.API.Data.Entities;

namespace RemittanceApp.API.Data
{
    public class AppDbContext: DbContext
    {
        public DbSet<PayoutTransaction> PayoutTransactions { get; set; } = default!;
        public DbSet<FeeConfiguration> FeeConfigurations { get; set; } = default!;
        public DbSet<Wallet> Wallets { get; set; } = default!;

        
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Wallet>(entity =>
            {
                entity.HasKey(e => e.WalletId);
                entity.Property(e => e.Currency).IsRequired().HasMaxLength(3);
                entity.Property(e => e.Balance).HasColumnType("decimal(18,2)");
            });
            modelBuilder.Entity<PayoutTransaction>()
       .HasKey(pt => pt.TransactionId);

    
        }
    }
}
