namespace Encapsulation;

public class Encap
{
	protected internal int x = 3;
}

class ChildEncap : Encap 
{
	public void getX()
	{
		Console.WriteLine(x);
	}
}
