namespace Domain
{
    public class PlanManager
    {
        private readonly IPlanRepository mPlanRepository;
        private readonly Plan mPlan;

        public PlanManager(IPlanRepository planRepository)
        {
            mPlanRepository = planRepository;
            mPlan = new Plan();

            mPlanRepository.AddPlan(mPlan);
        }

        // TODO: Be able to look at progress towards goals **** not easy
        //       Reset / add to things when month is up (need a way to configure <end of month>)

        public void GetProgress()
        {
            // TODO: Does this belong in the transaction service? Somewhere above that?
            // Algorithm:
            // Get all transactions for the current month (parameter?)
            // Compare transactions to the plan's goals...
        }

        /// <summary>
        /// Adds a new goal to the plan.
        /// </summary>
        /// <param name="name">The name of the category to use.</param>
        /// <param name="amount">The amount to allow in bucket.</param>
        public void AddGoal(string name, double amount)
        {
            var cat = new Category(name);
            var goal = new Goal(cat, amount);

            mPlan.AddGoal(goal);
            mPlanRepository.UpdatePlan(mPlan);
        }

        /// <summary>
        /// Adds an income to the plan.
        /// </summary>
        /// <param name="id">The id of the income to use.</param>
        /// <param name="amount">How much the monthly income is.</param>
        public void AddIncome(int id, double amount)
        {
            var income = new Income(id, amount);

            mPlan.AddIncome(income);
            mPlanRepository.UpdatePlan(mPlan);
        }
    }
}