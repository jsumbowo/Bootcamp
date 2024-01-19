using BenchmarkDotNet.Attributes;

[MemoryDiagnoser]
public class MethodBenchmark

{
	[Benchmark]
	public Task MethodOne()
	{
		return Task.Delay(2000);
	}
	[Benchmark]
	public async Task MethodTwo()
	
	{
		await Task.Delay(2000);
	}
}