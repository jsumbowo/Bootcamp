// Event handler use to know which publisher publish an event or which subscriber subs to an event
public class YoutuberEventHandler
{
	public EventHandler mySubs = null!;
	public string ID {get;}
	public YoutuberEventHandler(string myID)
	{
		this.ID = myID;
	}
	public bool UploadVideo()
	{
		Console.WriteLine($"{ID} Is Uploading Video");
		SendNotification();
		return true;
	}
	public bool SendNotification()
	{
		mySubs?.Invoke(this, EventArgs.Empty);
		return true;
	}
	// method to add new subs
	public bool AddNewSub(EventHandler newSubs)
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
    public override string ToString()
    {
        return $"Youtuber {ID}";
    }
}
public class PublisherEventHandler
{
	public EventHandler<MyEventArgs>? mySubs;
	public string ID {get;}
	public PublisherEventHandler(string myID)
	{
		this.ID = myID;
	}
	public bool UploadVideo()
	{
		Console.WriteLine($"{ID} Is Uploading Video");
		SendNotification();
		return true;
	}
	// method to add new subs
	public bool AddNewSub(EventHandler<MyEventArgs> newSubs)
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
	public bool SendNotification()
	{
		mySubs?.Invoke(this, new MyEventArgs(){stringData = $"Publisher {ID} upload video"});
		return true;
	}
}

public class MyEventArgs:EventArgs

{
	public string stringData = "";
}

public class SubscriberEventHandler
{
	public string ID{get;}
	public SubscriberEventHandler(string subsId)
	{
		ID = subsId;
	}
	public void GetNotification(object sender, EventArgs e)
	{
		Console.WriteLine($"Subscriber {this} has notofied: {sender} upload a new video !!!");
	}
	public void GetNotificationPublisher(object sender, MyEventArgs e)
	{
		Console.WriteLine($"Subscriber {this} has notofied: "+ e.stringData);
	}
	public override string ToString()
	{
		return ID;
	}
}

