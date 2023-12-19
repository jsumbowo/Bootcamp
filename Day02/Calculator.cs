class Calculator
{
	public double Add(double a, double b, params double [] numbers)
	{
		double result = a + b;
		foreach (double number in numbers)
		{
			result += number;
		}
		return result;
	}
	
	public double Mul(double a, double b)
	{
		double result = a * b;
		return result;
	}
	
	public double Div(double a, double b)
	{
		double result = a / b;
		return result;
	}
}