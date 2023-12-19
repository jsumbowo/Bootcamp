class Dog
{
	public string name;
	public int age;
	public string species;
	
	public void Greet()
	{
		Console.WriteLine($"Woof !!!, my name is {name}");
		Console.WriteLine($"I am a {species} dog and I am {age} years old");
	}
	
	public Dog(string dogName, int dogAge, string dogSpecies)
	{
		name = dogName;
		age = dogAge;
		species = dogSpecies;
	}
	
}