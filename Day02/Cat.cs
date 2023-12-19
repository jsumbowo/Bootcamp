class Cat : Animal
{

	public string species;
	
	public void Greet()
	{
		Console.WriteLine($"Meaw !!!, my name is {name}");
		Console.WriteLine($"I am a {species} cat and I am {age} years old");
	}
	
	public Cat(string catName = "unknown", int catAge = 0, string catSpecies = "unknown")
	{
		name = catName;
		age = catAge;
		species = catSpecies;
		Greet();
	}
	
}