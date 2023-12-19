class Bird : Animal
{

	public string species;
	
	public void Greet()
	{
		Console.WriteLine($"Qiu Qiu !!!, my name is {name}");
		Console.WriteLine($"I am a {species} and I am {age} years old");
	}
	
	public Bird(string birdName = "unknown", int birdAge = 0, string birdSpecies = "unknown")
	{
		name = birdName;
		age = birdAge;
		species = birdSpecies;
		Greet();
	}
	
}