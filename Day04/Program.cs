// See https://aka.ms/new-console-template for more information
using System.Net.NetworkInformation;
using System.Text;
using System.Xml.XPath;

class Program
{
	static void Main()
	{
		string[] myInput = { "10", "+", "12", "/", "2", "-", "6" };

		int lengthMyInput = myInput.Length;
		int mathOpIndex = 1;
		int maxIndex = myInput.Length - 2;

		if (lengthMyInput == 3)
		{
			Console.WriteLine("The result is: " + MathCalculation(myInput[0], myInput[2], myInput[1]));
		}
		else
		{
			while (maxIndex >= 3)
			{
				if (IsMathOrderRight(myInput, mathOpIndex))
				{
					double result = MathCalculation(myInput[mathOpIndex - 1], myInput[mathOpIndex + 1], myInput[mathOpIndex]);
					ArrayUpdate(myInput, result, mathOpIndex, maxIndex);
				}
				else
				{
					double result = MathCalculation(myInput[mathOpIndex + 1], myInput[mathOpIndex + 3], myInput[mathOpIndex + 2]);
					ArrayUpdate(myInput, result, mathOpIndex + 2, maxIndex);
				}
				maxIndex -= 2 ;
			}
			Console.WriteLine("The result is: " + MathCalculation(myInput[0], myInput[2], myInput[1]));
		}
	}

	static bool IsMathOrderRight(string[] input, int mathOpIndex)
	{
		bool result;
		if ((input[mathOpIndex] == "+" | input[mathOpIndex] == "-") & (input[mathOpIndex + 2] == "*" | input[mathOpIndex + 2] == "/"))
		{
			result = false;
		}
		else
		{
			result = true;
		}
		return result;
	}
	static double MathCalculation(string firstNumber, string secNumber, string mathOp)
	{
		double firstNum = double.Parse(firstNumber);
		double secNumb = double.Parse(secNumber);
		double result;
		if (mathOp == "+")
		{
			result = firstNum + secNumb;
		}
		else if (mathOp == "-")
		{
			result = firstNum - secNumb;
		}
		else if (mathOp == "*")
		{
			result = firstNum * secNumb;
		}
		else if (mathOp == "/")
		{
			result = firstNum / secNumb;
		}
		else
		{
			result = 0;
		}
		return result;
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
