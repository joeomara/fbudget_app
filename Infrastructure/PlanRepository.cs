using Domain;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Infrastructure
{
    /// <summary>
    /// This class is the data acess layer for plans.
    /// </summary>
    public class PlanRepository : IPlanRepository
    {
        #region Public Methods

        /// <summary>
        /// Adds a plan to the database.
        /// </summary>
        /// <param name="plan">The plan.</param>
        /// <returns>The plan that was added.</returns>
        public Plan AddPlan(Plan plan)
        {
            if (plan == null)
            {
                throw new ArgumentNullException(nameof(plan));
            }

            using (var db = new Model.BudgetContext())
            {
                db.Plans.Add(Create(plan));

                db.SaveChanges();
            }

            return plan;
        }

        /// <summary>
        /// Updates a plan in the database.
        /// TODO: Examine performance (are includes needed here?).
        /// </summary>
        /// <param name="plan">The plan to update.</param>
        public void UpdatePlan(Plan plan)
        {
            if (plan == null)
            {
                throw new ArgumentNullException(nameof(plan));
            }

            var dbPlan = Create(plan);

            using (var db = new Model.BudgetContext())
            {
                var old = db.Plans.SingleOrDefault(o => o.Id == plan.Id);
                if (old == null)
                {
                    throw new ArgumentException("The plan was not found.");
                }

                old.Income = Create(plan.Income);
                old.Goals = Create(plan.Goals).ToList();

                db.SaveChanges();
            }
        }

        #endregion Public Methods

        #region Private Methods

        private Model.Plan Create(Plan plan)
        {
            return new Model.Plan
            {
                Goals = new List<Model.Goal>(plan.Goals.Select(Create)),
                Income = Create(plan.Income)
            };
        }

        private Model.Income Create(Income income)
        {
            return new Model.Income
            {
                Id = income.Id,
                Amount = income.Amount
            };
        }

        private Model.Goal Create(Goal goal)
        {
            return new Model.Goal
            {
                Amount = goal.Amount,
                Id = goal.Id,
                Category = Create(goal.Category)
            };
        }

        private Model.Category Create(Category category)
        {
            return new Model.Category
            {
                Name = category.Name
            };
        }

        private IEnumerable<Model.Goal> Create(IEnumerable<Goal> goals)
        {
            return goals.Select(o => Create(o));
        }

        #endregion Private Methods
    }
}