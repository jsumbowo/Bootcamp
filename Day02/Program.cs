// See https://aka.ms/new-console-template for more information
using System.Reflection.Metadata.Ecma335;
using System.Xml.XPath;

class Program
{
	static void Main()
	{
		// Uncomment this following line for Dog class testing
		// Dog Bruno = new Dog("Bruno");
		
		// Cat Oreo = new Cat("Oreo", 1, "British Shorthair");
		
		// Bird Pulp = new Bird("Pulp", 1, "Love Bird");
		
		// Uncomment this following line for Calculator class testing
		// Calculator myCalc = new Calculator();
		// double myResult = myCalc.Add(2,3,9.2);
		// Console.WriteLine($"The result is: {myResult}");
		
		// Console.WriteLine("This is your calculator, please put an input !!!");
		// string userInput  = "12 + 15";
		// string[] eachInput = userInput.Split(' ');
		// double firstNum = Double.Parse(eachInput[0]);
		// double secNum    = Double.Parse(eachInput[2]);
		// double result = 0;
		
		// if (eachInput[1] == "+")
		// {
		// 	result = firstNum + secNum;
		// }
		// else if(eachInput[2] == "-")
		// {
		// 	result = firstNum - secNum;
		// }
		// else if(eachInput[2] == "x")
		// {
		// 	result = firstNum * secNum;
		// }
		// else if(eachInput[2] == "/")
		// {
		// 	result = firstNum / secNum;
		// }
		// else
		// {
		// 	Console.WriteLine("Please input the rights math symbol.");
		// }
		
		// Console.WriteLine($"The result is {result}");
		
		Child2 myAnimal = new Child2(2, "Bruno");
		
	}
}