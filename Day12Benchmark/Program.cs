using System.Diagnostics;
using BenchmarkDotNet.Running;
class Program
{
	static void Main() 
	{
		// BenchmarkRunner.Run<StringBenchmark>();
		
		//MULTI THREADING
		Stopwatch stopwatch = new();
		Console.WriteLine("Starting Program");
		stopwatch.Start();
		Thread tTaskOne = new Thread(TaskOne);
		Thread tTaskTwo = new Thread(TaskTwo);
		
		tTaskOne.Start();
		tTaskTwo.Start();
		tTaskOne.Join();
		tTaskTwo.Join();
		
		stopwatch.Stop();
		Console.WriteLine($"\nProgram complete. Elapsed time: {stopwatch.ElapsedMilliseconds}ms");
	}
	public static void TaskOne()
	
	{
		for(int i =0; i<100; i++)
		
		{
			Console.Write('+');
		}
	}
	public static void TaskTwo()
	
	{
		for(int i =0; i<100; i++)
		
		{
			Console.Write('-');
		}
	}
}