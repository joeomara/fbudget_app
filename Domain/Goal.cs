using System;

namespace Domain
{
    /// <summary>
    /// This class represents a categories allocated amount.
    /// </summary>
    public class Goal
    {
        #region Public Constructors

        /// <summary>
        /// Initializes an instance of the <see cref="Goal"/> class.
        /// </summary>
        /// <param name="id">The identifier for the goal.</param>
        /// <param name="category">The category for this goal.</param>
        /// <param name="amount">The allocated budget for this goal.</param>
        public Goal(Guid id, Category category, double amount)
        {
            Id = id;
            Amount = amount;
            Category = category;
        }

        /// <summary>
        /// Initializes an instance of the <see cref="Goal"/> class.
        /// </summary>
        /// <param name="category">The category for this goal.</param>
        /// <param name="amount">The allocated budget for this goal.</param>
        public Goal(Category category, double amount)
        {
            Id = Guid.NewGuid();
            Amount = amount;
            Category = category;
        }

        #endregion Public Constructors

        #region Public Properties

        /// <summary>
        /// The budget for the category.
        /// </summary>
        public double Amount { get; private set; }

        /// <summary>
        /// The category for this goal.
        /// </summary>
        public Category Category { get; private set; }

        /// <summary>
        /// The identifier for the goal.
        /// </summary>
        public Guid Id { get; private set; }

        #endregion Public Properties

        #region Public Methods

        /// <summary>
        /// Used to update the amount for the category.
        /// </summary>
        /// <param name="amount">The amount to update to.</param>
        public void UpdateAmount(double amount)
        {
            Amount = amount;
        }

        #endregion Public Methods
    }
}