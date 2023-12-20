class Animal2
{
	public int age;
	public string name;
	public Animal2(int myAge , string myName)
	{
		age = myAge;
		name = myName;
	}
	public Animal2(int myAge)
	{
		age = myAge;
		name = "unknown";
	}
	public Animal2()
	{
		name = "unknown";
		age  = 0;
		Console.Write("Animal is born");
	}
}

class Child2 : Animal2
{
	string species;
	public Child2(int myAge, string myName, string mySpecies) : base(myAge, myName)
	{
		species = mySpecies;
		Console.WriteLine(name);
	}
}