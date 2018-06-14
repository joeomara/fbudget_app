namespace Infrastructure.Model
{
    public class Transaction
    {
        #region Public Properties

        public double Amount { get; set; }
        public virtual Category Category { get; set; }
        public string Description { get; set; }
        public int Id { get; set; }

        #endregion Public Properties
    }
}