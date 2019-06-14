namespace Skreet2k.Common.Models
{
    /// <summary>
    /// Result model with content
    /// </summary>
    /// <typeparam name="T">Content type</typeparam>
    public class Result<T> : Result
    {
        public Result(T content)
        {
            Content = content;
        }

        public T Content { get; set; }
    }
    /// <summary>
    /// Result model
    /// </summary>
    public class Result
    {
        public Result() { }
        public string ErrorMessage { get; set; }

        public bool IsSuccess => ErrorMessage != null;
    }
}
