abstract class Animal
{
	private int _age;
	string name;
	
	public Animal(int aAge, string aName)
	{
		name = aName;
		_age = aAge;
	}
	
	public void PrintAge()
	{
		Console.WriteLine("Age: " + _age);
	}
	
	public abstract void MakeSound();
	public virtual void Run()
	{
		Console.WriteLine("Animal is running");
	}
}

class Dog : Animal
{
	public Dog(int aAge, string aName): base(aAge, aName)
	{
	}
	
	public override void MakeSound()
	{
		Console.WriteLine("Bark");
	}
}