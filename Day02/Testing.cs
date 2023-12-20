class Animal2
{
	public int age;
	public string name;
	public Animal2(int myAge , string myName)
	{
		age = myAge;
		name = myName;
	}
}

class Child2 : Animal2
{
	public Child2(int myAge, string myName) : base (myAge, myName)
	{
		Console.WriteLine(name);
	}
}