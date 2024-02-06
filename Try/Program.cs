class Program
{
	static void Main()
	
	{
		IPrint printer = new Printer("hello world");
		printer.Print();
	}
}

public interface IPrint

{
	public void Print();
}

public class Printer: IPrint

{
	private string _data;
	public Printer(string data)
	
	{
		_data = data;
	}
	public void Print()
	
	{
		Console.WriteLine(_data);
	}
}