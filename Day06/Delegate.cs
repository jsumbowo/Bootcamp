public class SMS 
{
	public void SendSMS(string message)
	{
		Console.WriteLine("{SMS} The game status is " + message);
	}
}

public class Email 
{
	public void SendEmail(string message)
	{
		Console.WriteLine("{email} The game status is " + message);
	}
}
