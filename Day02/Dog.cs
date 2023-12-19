class Dog : Animal
{

	public string species;
	
	public void Greet()
	{
		Console.WriteLine($"Woof !!!, my name is {name}");
		Console.WriteLine($"I am a {species} dog and I am {age} years old");
	}
	
	public Dog(string dogName = "unknown", int dogAge = 0, string dogSpecies = "unknown")
	{
		name = dogName;
		age = dogAge;
		species = dogSpecies;
		Greet();
	}
	
}