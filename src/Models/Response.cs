namespace MyTaskList.src.Models
{
	internal class Response<T>
	{
		public bool IsError { get; set; }
		public string Message { get; set; }
		public T? Data { get; set; }

		public Response(bool isError, string message)
		{
			IsError = isError;
			Message = message;
		}

		public Response(bool isError, string message, T? data)
		{
			IsError = isError;
			Message = message;
			Data = data;
		}
	}
}
