using System.Diagnostics;
using System.Text;

class Program
{
	static void Main()
	
	{
		string myStr =  String.Empty;
		// StringBuilder myStrBuilder = new();
		int iteration = 10000;
		Stopwatch stopwatch = new();
		stopwatch.Start();
		for (int i = 0; i< iteration; i++)
		{
			myStr += "Hello World !";
			// myStrBuilder.Append("Hello World !");
		}
		stopwatch.Stop();
		Console.WriteLine(stopwatch.ElapsedMilliseconds);
	}
}
