using Domain;
using System.Linq;

namespace Infrastructure
{
    /// <summary>
    /// This class is the data access layer for transactions.
    /// </summary>
    public class TransactionRepository : ITransactionRepository
    {
        #region Public Methods

        /// <summary>
        /// Adds a new transaction to the database.
        /// </summary>
        /// <param name="transaction">The transaction to add.</param>
        /// <returns>The added transaction.</returns>
        public Transaction AddTransaction(Transaction transaction)
        {
            if (transaction == null)
            {
                throw new System.ArgumentNullException(nameof(transaction));
            }

            using (var db = new Model.BudgetContext())
            {
                db.Transactions.Add(Create(transaction));

                db.SaveChanges();
            }

            return transaction;
        }

        /// <summary>
        /// Gets the largest id used in the database.
        /// TODO: Make this more performant (hits DB twice).
        /// </summary>
        /// <returns>The largest id or 0.</returns>
        public int GetLatestId()
        {
            using (var db = new Model.BudgetContext())
            {
                if (!db.Transactions.Any())
                {
                    return 0;
                }

                return db.Transactions.Select(t => t.Id).Max();
            }
        }

        #endregion Public Methods

        #region Private Methods

        private Model.Transaction Create(Transaction transaction)
        {
            return new Model.Transaction
            {
                Amount = transaction.Amount,
                Id = transaction.Id,
                Description = transaction.Description,
                Category = Create(transaction.Category)
            };
        }

        private Model.Category Create(Category category)
        {
            return new Model.Category
            {
                Name = category.Name
            };
        }

        #endregion Private Methods
    }
}