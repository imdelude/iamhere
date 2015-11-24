namespace iamhere.Requests
{
    public interface IRequestStringBuilder<in T> where T : Request
    {
        /// <summary>
        /// Builds a request string from the given request data structure.
        /// </summary>
        /// <param name="request">The request that will be used to build the string</param>
        /// <returns>The built request string that can be used to make a request to the API.</returns>
        string Build(T request);
    }
}