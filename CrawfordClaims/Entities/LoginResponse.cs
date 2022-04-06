namespace CrawfordClaims
{ 
    /// <summary>
    /// The login response data.
    /// </summary>
    public class LoginResponse
    {
        /// <summary>
        /// Gets or sets the UserId.
        /// </summary>
        /// <value>The UserId.</value>
        public int UserId { get; set; }

        /// <summary>
        /// Gets or sets the Token.
        /// </summary>
        /// <value>The Token.</value>
        public string Token { get; set; }
    }
}
