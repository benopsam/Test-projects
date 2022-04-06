namespace CrawfordClaims.Models
{
    /// <summary>
    /// The login data.
    /// </summary>
    public class LoginData
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
    }
}
