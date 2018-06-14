namespace Domain
{
    /// <summary>
    /// This class is a value object that represents buckets for spending.
    /// </summary>
    public class Category
    {
        #region Public Constructors

        /// <summary>
        /// Initializes an instance of the <see cref="Category"/> class.
        /// </summary>
        /// <param name="name">The name of the category.</param>
        public Category(string name)
        {
            Name = name ?? throw new System.ArgumentNullException(nameof(name));
        }

        #endregion Public Constructors

        #region Public Properties

        /// <summary>
        /// The name of this category.
        /// </summary>
        public string Name { get; private set; }

        #endregion Public Properties

        #region Public Methods

        /// <summary>
        /// Overrides the equals operation for this value object.
        /// </summary>
        /// <param name="obj">The other category.</param>
        /// <returns>True if they are the same category; false otherwise.</returns>
        public override bool Equals(object obj)
        {
            var cat = obj as Category;
            if (cat == null)
            {
                return false;
            }

            return Name == cat.Name;
        }

        /// <summary>
        /// Overrides the hash operation for this value object.
        /// </summary>
        /// <returns>The hashcode.</returns>
        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }

        #endregion Public Methods
    }
}