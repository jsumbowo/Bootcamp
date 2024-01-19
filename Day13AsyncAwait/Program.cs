

using System.Diagnostics;
using BenchmarkDotNet.Running;
class Program 

{
	static async void Main()
	
	{
		// Untuk stop task atau thread secara paksa kita bias gunakan cancellation token
		// 1. Buat cancelation token source dan cancellation token (untuk diinfokan ke method)
		// 2. Di method nya masukkin input token nya 
		// 3. Cancel thread dengan CancellationTokenSource.Cancel()
		CancellationTokenSource cts = new();
		CancellationToken token = cts.Token;
		Task task = DoWorkAsync(token);

		Console.WriteLine("Press 'c' to cancel the operation.");
		if (Console.ReadKey().KeyChar == 'c')
		{
			cts.Cancel();
		}
		//Try karena ketika token membaca ada cancel, mereka ngebalikin error
		try
		{
			await task;
			Console.WriteLine("Operation completed.");
		}
		catch (OperationCanceledException)
		{
			Console.WriteLine("Operation canceled.");
		}
	}
	static async Task DoWorkAsync(CancellationToken token)
	{
		for (int i = 0; i < 10; i++)
		{
			//Checking apakah token menerima input CancellationRequested ? 
			token.ThrowIfCancellationRequested();

			Console.WriteLine($"Work in progress: {i * 10}%");
			await Task.Delay(20000,token);
		}
}
	
}
