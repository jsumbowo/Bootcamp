// See https://aka.ms/new-console-template for more information
class Program
{
	static void Main()
	{
		// Youtuber youtuber = new Youtuber();
		// Subscriber subs1  = new Subscriber("subs1", youtuber);
		// Subscriber subs2  = new Subscriber("subs2", youtuber);
		// youtuber.UploadVideo();
		
		//Trying Event Handler
		// YoutuberEventHandler Atta = new YoutuberEventHandler("Atta");
		// YoutuberEventHandler Radit = new YoutuberEventHandler("Radit");
		// PublisherEventHandler Bernard = new PublisherEventHandler("Bernard");
		// SubscriberEventHandler Yanto = new SubscriberEventHandler("Yanto");
		// SubscriberEventHandler Jarot = new SubscriberEventHandler("Jarot");
		
		// Atta.AddNewSub(Yanto.GetNotification);
		// Radit.AddNewSub(Yanto.GetNotification);
		// Radit.AddNewSub(Jarot.GetNotification);
		// Bernard.AddNewSub(Jarot.GetNotificationPublisher);
		
		// Atta.UploadVideo();
		// Radit.UploadVideo();
		// Bernard.UploadVideo();
		
		//TRYING ACTION
		YoutuberAction Radit = new YoutuberAction("Radit");
		YoutuberAction Atta = new YoutuberAction("Atta");
		SubscriberAction Jarwo = new SubscriberAction("Jarwo");
		SubscriberAction Kamil = new SubscriberAction("Kamil");
		Radit.AddSubsriber(Jarwo.GetNotification);
		Radit.AddSubsriber(Kamil.GetNotification);
		Radit.UploadVideo();
		Atta.UploadVideo();
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