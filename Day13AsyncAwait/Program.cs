

using System.Diagnostics;
using BenchmarkDotNet.Running;
using System.Threading.Tasks;
using System.Security.AccessControl;
using System;
using System.Threading;
class Program 

{
	public static SemaphoreSlim smp = new SemaphoreSlim(3);
	static async Task Main()
	
	{
		// // Untuk stop task atau thread secara paksa kita bias gunakan cancellation token
		// // 1. Buat cancelation token source dan cancellation token (untuk diinfokan ke method)
		// // 2. Di method nya masukkin input token nya 
		// // 3. Cancel thread dengan CancellationTokenSource.Cancel()
		// CancellationTokenSource cts = new();
		// CancellationToken token = cts.Token;
		// Task task = DoWorkAsync(token);

		// Console.WriteLine("Press 'c' to cancel the operation.");
		// if (Console.ReadKey().KeyChar == 'c')
		// {
		// 	cts.Cancel();
		// }
		// //Try karena ketika token membaca ada cancel, mereka ngebalikin error
		// try
		// {
		// 	await task;
		// 	Console.WriteLine("Operation completed.");
		// }
		// catch (OperationCanceledException)
		// {
		// 	Console.WriteLine("Operation canceled.");
		// }
		
		// Semaphore is to limit thread that is used for certain operation (access data)
		// Masukin semaphore di method atau resource yang ingin di akses oleh banyak Thread
		// di main code tetap biasa 
		Task[] tasks = new Task[10];
		for (int i = 1; i <= 10; i++)
		{
			int taskId = i;
			tasks[i - 1] = Task.Run( () =>  DoSomeWork(taskId));
		}

		await Task.WhenAll(tasks);
		Console.WriteLine("All task finished");
	
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
	static async void DoSomeWork(int id)
	
	{
		Console.WriteLine($"Task {id} is in waiting line");
		try
		
		{
			smp.Wait();
			Console.WriteLine("Success: Task " + id + " is Doing its work");
			await Task.Delay(7000);
			Console.WriteLine($"Task {id} Exit.");
			
		}
		finally
		
		{
			smp.Release();	
		}
		
	}
}
