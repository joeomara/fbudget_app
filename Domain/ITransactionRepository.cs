namespace Domain
{
    /// <summary>
    /// Defines an interface to the transaction repository.
    /// </summary>
    public interface ITransactionRepository
    {
        #region Public Methods

        /// <summary>
        /// Adds a transaction to persistence.
        /// </summary>
        /// <param name="transaction">The transaction to add.</param>
        /// <returns>The added transaction.</returns>
        Transaction AddTransaction(Transaction transaction);

        /// <summary>
        /// Gets the latest id used in storing transactions.
        /// </summary>
        /// <returns>The largest id in the repository.</returns>
        int GetLatestId();

        // TODO: Add a way to get all transactions
        //       Query transactions based on category

        #endregion Public Methods
    }
}