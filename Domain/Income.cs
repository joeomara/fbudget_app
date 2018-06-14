namespace Domain
{
    /// <summary>
    /// This class represents income that the user has.
    /// </summary>
    public class Income
    {
        #region Public Constructors

        /// <summary>
        /// Initializes an instance of the <see cref="Income"/> class.
        /// </summary>
        /// <param name="id">The identifier for the income.</param>
        /// <param name="amount">The monthly income of the user.</param>
        public Income(int id, double amount)
        {
            Id = id;
            Amount = amount;
        }

        #endregion Public Constructors

        #region Public Properties

        /// <summary>
        /// The monthly income for the user.
        /// </summary>
        public double Amount { get; private set; }

        /// <summary>
        /// An identifier for this income (used when there are multiple income sources).
        /// </summary>
        public int Id { get; private set; }

        #endregion Public Properties
    }
}