using System.Net.Http.Headers;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

class CarData
{
	private string _carBrand;
	public string CarBrand
	{
		get {return _carBrand;}
		set
		{
			if (value == "Toyota" | value == "Nissan" | value == "Honda")
			{
				_carBrand = value;
			}
			else 
			{
				_carBrand = "unknown";
			}
		}
	}
	public CarData()
	{
		CarBrand = AskingCarBrand();
		Console.WriteLine("Your car brand is "+ CarBrand);
	}
	public string AskingCarBrand()
	{
		Console.WriteLine("What is your car brand? (Toyota, Honda, Nissan)");
		string result = Console.ReadLine() ?? String.Empty;
		return result;
	}
	
}