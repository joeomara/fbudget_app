namespace Domain
{
    /// <summary>
    /// Defines an interface to the plan repository.
    /// </summary>
    public interface IPlanRepository
    {
        #region Public Methods

        /// <summary>
        /// Adds a plan to persistence.
        /// </summary>
        /// <param name="plan">The plan to add.</param>
        Plan AddPlan(Plan plan);

        /// <summary>
        /// Updates a plan in persistence.
        /// </summary>
        /// <param name="plan">The plan with the updates.</param>
        void UpdatePlan(Plan plan);

        #endregion Public Methods
    }
}