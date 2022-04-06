namespace CrawfordClaims
{
    /// <summary>
    /// The user data.
    /// </summary>
    public class User
    {
        /// <summary>
        /// Gets or sets the UserId.
        /// </summary>
        /// <value>The UserId.</value>
        public int UserId { get; set; }

        /// <summary>
        /// Gets or sets the UserName.
        /// </summary>
        /// <value>The UserName.</value>
        public string UserName { get; set; }

        /// <summary>
        /// Gets or sets the Password.
        /// </summary>
        /// <value>The Password.</value>
        public string Password { get; set; }

        /// <summary>
        /// Gets or sets the Display name.
        /// </summary>
        /// <value>The Display name.</value>
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets the value of IsActive.
        /// </summary>
        /// <value>The value for IsActive.</value>
        public bool IsActive { get; set; }
    }
}
