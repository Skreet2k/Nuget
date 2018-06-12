namespace Common.Framework.Models
{
	public class Result<T> : Result
	{
		public Result(T content)
		{
			Content = content;
		}

		public T Content { get; set; }
	}

	public class Result
	{
		public Result()
		{
		}

		public Result(string errorMessage)
		{
			ErrorMessage = errorMessage;
		}

		public string ErrorMessage { get; set; }

		public bool IsSuccess => ErrorMessage != null;
	}
}