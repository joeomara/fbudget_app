namespace Domain
{
    public class TransactionService
    {
        #region Private Fields

        private readonly ITransactionRepository mTransactionRepository;
        private int mLatestId;

        #endregion Private Fields

        #region Public Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionService"/> class.
        /// </summary>
        /// <param name="transactionRepository"></param>
        public TransactionService(ITransactionRepository transactionRepository)
        {
            mTransactionRepository = transactionRepository;
            mLatestId = mTransactionRepository.GetLatestId();
        }

        #endregion Public Constructors

        #region Public Methods

        /// <summary>
        /// Adds a transaction to the repository.
        /// </summary>
        /// <param name="amount">The amount of the transaction.</param>
        /// <param name="description">The description of the transaction.</param>
        /// <param name="category">The category that the transaction falls into.</param>
        public void AddTransaction(double amount, string description, Category category)
        {
            mLatestId++;
            var transaction = new Transaction(mLatestId, amount, category, description);

            mTransactionRepository.AddTransaction(transaction);
        }

        #endregion Public Methods
    }
}