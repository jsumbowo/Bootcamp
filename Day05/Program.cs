// See https://aka.ms/new-console-template for more information
class Program
{
	static void Main()
	{
		Animal myAnimal = new Dog(3, "Bruno");
		// myAnimal.PrintAge();
		Dog myDog = new Dog(4, "Bruno");
		myDog.PrintAge();
	}
}