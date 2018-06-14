using System;
using System.Collections.Generic;
using System.Linq;

namespace Domain
{
    /// <summary>
    /// This class represents the overall budget for the user.
    /// It contains the income and goals of the user.
    /// </summary>
    public class Plan
    {
        #region Private Fields

        private List<Goal> mGoals;

        #endregion Private Fields

        #region Public Constructors

        /// <summary>
        /// Initializes an instance of the <see cref="Plan"/> class.
        /// </summary>
        /// <param name="goals">The list of goals.</param>
        /// <param name="income">The income of the user.</param>
        public Plan(IEnumerable<Goal> goals, Income income = null)
        {
            Id = Guid.NewGuid();
            Income = income;
            mGoals = new List<Goal>(goals);
        }

        /// <summary>
        /// Initializes an instance of the <see cref="Plan"/> class.
        /// </summary>
        /// <param name="income">The income of the user.</param>
        public Plan(Income income = null)
        {
            Income = income;
            mGoals = new List<Goal>();
        }

        #endregion Public Constructors

        #region Public Properties

        /// <summary>
        /// The id of the plan.
        /// </summary>
        public Guid Id { get; private set; }

        /// <summary>
        /// The goals for the user.
        /// </summary>
        public IEnumerable<Goal> Goals => mGoals.AsEnumerable();

        /// <summary>
        /// The income of the user.
        /// </summary>
        public Income Income { get; private set; }

        #endregion Public Properties

        #region Public Methods

        /// <summary>
        /// Adds a goal to the user's plan.
        /// </summary>
        /// <param name="goal">The goal to add.</param>
        public void AddGoal(Goal goal)
        {
            // TODO: Should this be restrained by income?
            mGoals.Add(goal);
        }

        /// <summary>
        /// Adds income to the user's plan.
        /// </summary>
        /// <param name="income">The user's income.</param>
        public void AddIncome(Income income)
        {
            Income = income;
        }

        public bool RemoveGoal(Guid id)
        {
            var goal = mGoals.Find(o => o.Id == id);
            if (id == null)
            {
                throw new ArgumentException($"This user does not have a goal with the id: {id}.");
            }

            return mGoals.Remove(goal);
        }

        /// <summary>
        /// Updates a user's goal.
        /// </summary>
        /// <param name="id">The identifier of the goal to update.</param>
        /// <param name="amount">The amount to change it to.</param>
        public void UpdateGoal(Guid id, double amount)
        {
            var goal = mGoals.Find(o => o.Id == id);
            if (id == null)
            {
                throw new ArgumentException($"This user does not have a goal with the id: {id}.");
            }

            goal.UpdateAmount(amount);
        }

        #endregion Public Methods
    }
}