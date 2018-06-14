using System;
using System.Collections.Generic;

namespace Infrastructure.Model
{
    public class Plan
    {
        #region Public Properties

        public Guid Id { get; set; }
        public virtual List<Goal> Goals { get; set; }
        public virtual Income Income { get; set; }

        #endregion Public Properties
    }
}