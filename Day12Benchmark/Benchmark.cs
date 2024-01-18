using System.Text;
using BenchmarkDotNet.Attributes;

[MemoryDiagnoser]
public class StringBenchmark
{
	[Params(1, 10, 100)]
	public int Iteration;
	[Benchmark]
	
	public void StringTest()
	{
		string myStr = "";
		for(int i = 0; i<Iteration; i++)
	
		{
			myStr+='a';
		}
	}
	
	[Benchmark]
	public void StringBuilderTest()
	
	{
		StringBuilder myStrBuilder = new();
		for(int i = 0; i < Iteration; i++)
		
		{
			myStrBuilder.Append('a');
		}
	}
	 
}

