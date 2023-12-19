// See https://aka.ms/new-console-template for more information
class Program
{
	static void Main()
	{
		// Dog Bruno = new Dog("Bruno", 1, "pomerian");
		// Bruno.Greet();
		
		Calculator myCalc = new Calculator();
		
		double myResult = myCalc.Add(2,3,9.2);
		
		Console.WriteLine($"The result is: {myResult}");
	}
}