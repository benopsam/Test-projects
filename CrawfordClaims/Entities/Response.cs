namespace CrawfordClaims
{
    /// <summary>
    /// The Response details.
    /// </summary>
    /// <typeparam name="T">The data type.</typeparam>
    public class Response<T>
    {
        public Response()
        {
        }

        /// <summary>
        /// Gets or sets the response data.
        /// </summary>
        public T ResponseData { get; set; }

        /// <summary>
        /// Gets or sets HasError. 
        /// </summary>
        public bool HasError { get; set; }

        /// <summary>
        /// Gets or sets the error text.
        /// </summary>
        public string ErrorText { get; set; }
    }
}
