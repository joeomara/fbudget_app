using System;

namespace Infrastructure.Model
{
    public class Goal
    {
        #region Public Properties

        public double Amount { get; set; }
        public virtual Category Category { get; set; }
        public Guid Id { get; set; }

        #endregion Public Properties
    }
}