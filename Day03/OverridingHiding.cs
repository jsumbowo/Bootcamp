namespace Day03;

public class BaseOveriding
{
	public string id = "base";
	public virtual void Demo()
	{
		Console.WriteLine("This is demo in base class");
	}
}

public class ChildOveriding : BaseOveriding
{
	public new string id = "chlid";
	public override void Demo()
	{
		Console.WriteLine("This is Demo in child class");
	}
}

public class GrandChildOveriding : ChildOveriding
{
	public new string id = "grandchild";
	public override void Demo()
	{
		Console.WriteLine("This is Demo in grand child class");
	}
}