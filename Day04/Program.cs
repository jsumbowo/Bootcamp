// See https://aka.ms/new-console-template for more information
class Program
{
	static void Main()
	{
		string[] myInput = { "10", "+", "12", "/", "2", "-", "10" };
		ArrayUpdate(myInput, 6, 3, 5);
		foreach(string eachInput in myInput)
		{
			Console.WriteLine(eachInput);
		}
	}

	static void ArrayUpdate(string[] input, double result, int indexMathOp, int maxIndex)

	{
		int indexAfterUpdate = 0;
		int indexBeforeUpdate = 0;

		while (indexAfterUpdate < maxIndex)
		{
			if (indexAfterUpdate != (indexMathOp - 1))
			{
				input[indexAfterUpdate] = input[indexBeforeUpdate];
				indexAfterUpdate++;
				indexBeforeUpdate++;
			}
			else
			{
				input[indexAfterUpdate] = result.ToString();
				indexAfterUpdate++;
				indexBeforeUpdate += 3;
			}
		}
		for (int i = maxIndex; i < input.Length; i++)
		{
			input[i] = "done";
		}
	}
}
