using System.Reflection.PortableExecutable;

public interface IHuman : IGreet, ILaugh, ICharacteristic
{
}
public interface ICharacteristic
{
	Characteristics Characteristics {get;} 
}
public interface IGreet
{
	public void Greet();
}

public interface ILaugh
{
	public void Laugh();
}
public class Characteristics 
{
	public string colorTone = "diverse";
	public string nationalAnthem = "Indonesia Raya"; 
}
public class Indonesian : IHuman
{
	private string _name;
	public Characteristics Characteristics {get; private set;}
	public Indonesian(string myName, Characteristics characteristics)
	{
		Characteristics = characteristics;
		_name = myName;
	}
	public void Greet()
	{
		Console.WriteLine("Halo nama saya " + _name);
	}

	public void Laugh()
	{
		Console.WriteLine("WKWKWK");
	}
	
}

