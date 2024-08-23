class AsyncMain()
{
	public static int Main()
	{
		/* 
		 * Call the async method and wait syncronously for it to
		 * complete.
		 * GetAwaiter().GetResult() is used to block the main thread
		 * until the asyncronous operation completes
		 */
		return AsyncConsoleWork().GetAwaiter().GetResult();
	}

	// Async method that returns a Task<int>
	private static async Task<int> AsyncConsoleWork()
	{
		/*
		 * Main body of the async method
		 * Perform asynchronous operations here
		 * Returning 0 as the result of the task
		 */
		return 0;
	}
}
