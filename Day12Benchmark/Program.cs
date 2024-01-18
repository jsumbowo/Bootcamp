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
		Thread tTaskOne = new Thread(()=> TaskOne('+'));
		Thread tTaskTwo = new Thread(()=> TaskTwo('-'));
		Thread tExecption = new Thread(CatchExecption);
		
		tTaskOne.Start();
		tTaskTwo.Start();
		tExecption.Start();
		tTaskOne.Join();
		tTaskTwo.Join();
		tExecption.Join();
		
		stopwatch.Stop();
		Console.WriteLine($"\nProgram complete. Elapsed time: {stopwatch.ElapsedMilliseconds}ms");
	}
	public static void TaskOne(char ch)
	
	{
		for(int i =0; i<100; i++)
		
		{
			Console.Write(ch);
		}
	}
	public static void TaskTwo(char ch)
	
	{
		for(int i =0; i<100; i++)
		
		{
			Console.Write(ch);
		}
	}
	public static void ExecptionMaker()
	
	{
		throw new Exception("Error");
	}
	public static void CatchExecption()
	
	{
		try
		
		{
			ExecptionMaker();
		}
		catch(Exception)
		
		{
			
		}
	}
}