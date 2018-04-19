namespace Common.Models
{
	public class Result<T> : Result
	{
		public Result(T content)
		{
			Content = content;
			IsSuccess = true;
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
		public bool IsSuccess { get; set; }
	}
}