// See https://aka.ms/new-console-template for more information
class Program 
{
	static void Main()
	{
		//Lambda Expression => creating function without name (biasanya untuk assign ke delegate)
		Func <int, int, bool> myFunc;
		myFunc =(int a, int b) => {return a > b;};
		
		Action <string> myAction;
		myAction = (string message) => {Console.WriteLine($"{message}");};
		Console.WriteLine(myFunc(2,5));
		myAction("Hello World !");
	}
}

	//Null Reference Exception
	//string x = null;
	//x.Length.Dump();

	//IndexOutOfRangeException
	//int[] myInt = {1,2,3};
	//myInt[3].Dump();

	//RuntimeBinderException
	//dynamic a = "hello";
	//a = 3;
	//a = 3.0f;
	//a.AmbilNilaiSekarangJuga().Dump();
	
	//FormatException
	// string a = "3a";
	// int result = int.Parse(a);
