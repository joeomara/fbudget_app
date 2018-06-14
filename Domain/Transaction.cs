namespace Domain
{
    /// <summary>
    /// This class represents money that is spent.
    /// </summary>
    public class Transaction
    {
        #region Public Constructors

        /// <summary>
        /// Initializes an instance of the <see cref="Transaction"/> class.
        /// </summary>
        /// <param name="id">The identifier of the transaction.</param>
        /// <param name="amount">The amount of the transaction.</param>
        /// <param name="category">The category for this transaction.</param>
        /// <param name="description">A short description of the transaction.</param>
        public Transaction(int id, double amount, Category category, string description)
        {
            Id = id;
            Amount = amount;
            Category = category;
            Description = description;
        }

        #endregion Public Constructors

        #region Public Properties

        /// <summary>
        /// How much the transaction is.
        /// </summary>
        public double Amount { get; private set; }

        /// <summary>
        /// The category for the transaction.
        /// </summary>
        public Category Category { get; private set; }

        /// <summary>
        /// A short description of the transaction.
        /// </summary>
        public string Description { get; private set; }

        /// <summary>
        /// The identifier for the transaction.
        /// </summary>
        public int Id { get; private set; }
        

        // TODO: Date stamp needed for this

        #endregion Public Properties
    }
}