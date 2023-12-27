// See https://aka.ms/new-console-template for more information
using Day05;

class Program
{
	static void Main()
	{
		// Animal myAnimal = new Dog(3, "Bruno");
		// myAnimal.PrintAge();
		// Dog myDog = new Dog(4, "Bruno");
		// myDog.PrintAge();
		
		
		// EducationChecker educationChecker = new EducationChecker(new SurabayaStudent("Joel", 23));
		
		
		// Characteristics indonesian = new Characteristics();
		// Indonesian joel = new Indonesian("Joel", indonesian);
		// joel.Greet();
		// Console.WriteLine(joel.Characteristics.colorTone);
		
		// ThisStatic.Joke() ;
		ThisStatic.PostIncrement();
		ThisStatic.PreIncrement();
	}
}

public static class ThisStatic
{
	static int count = 0;
	static ThisStatic()
	{
		Console.WriteLine("Hello, this is static class");
	}
	
	public static void Joke()
	{
		Console.WriteLine("Whiteboards are remarkable");
	}
	
	public static void PostIncrement()
	{
		Console.WriteLine("Count before post-increment: "+ count);
		Console.WriteLine("Count after post-increment: "+ count++);
	}
	public static void PreIncrement()
	{
		Console.WriteLine("Count before pre-increment: "+ count);
		Console.WriteLine("Count after pre-increment: "+ ++count);
	}
}