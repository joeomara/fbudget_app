using System.Data.Entity;

namespace Infrastructure.Model
{
    internal class BudgetContext : DbContext
    {
        #region Public Properties

        public DbSet<Plan> Plans { get; set; }
        public DbSet<Transaction> Transactions { get; set; }

        #endregion Public Properties
    }
}