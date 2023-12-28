// See https://aka.ms/new-console-template for more information
class Program
{
	static void Main()
	{
		Youtuber youtuber = new Youtuber();
		Subscriber subs1  = new Subscriber("subs1", youtuber);
		Subscriber subs2  = new Subscriber("subs2", youtuber);
		youtuber.UploadVideo();
	}
}

public delegate void MySubs(string str);
class Youtuber
{
	private MySubs mySubs;
	public bool UploadVideo()
	{
		Console.WriteLine("Uploading Video");
		SendNotification("YOUTUBER HAS A NEW VIDEO !!!");
		return true;
	}
	// method to add new subs
	public bool AddNewSub(MySubs newSubs)
	{
		if (mySubs is null)
		
		{
			mySubs += newSubs;
			return true; 
		}
		else if(mySubs.GetInvocationList().Contains(newSubs))
		{
			return false;
		}
		else
		{
			mySubs += newSubs;
			return true;
		}
	}
	
	public string SendNotification(string message)
	{
		mySubs.Invoke(message);
		return message;
	}
}

class Subscriber
{
	string id;
	public Subscriber(string subsId, Youtuber youtuber)
	{
		id = subsId;
		youtuber.AddNewSub(this.GetNotification);
	}
	public void GetNotification(string message)
	{
		Console.WriteLine($"Subscriber {id} has notofied: {message}");
	}
}