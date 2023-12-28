class YoutuberAction
{
	public Action <string> mySubs;	
	string ID = null!; 
	public YoutuberAction(string myID)
	
	{
		ID =myID;
	}
	public void UploadVideo()
	{
		Console.WriteLine("{ID} is Uploading a video");
		SendNotification();
	}
	public void SendNotification()
	
	{
		string message = $"YoutuberAction {ID} has new video !!!";
		mySubs?.Invoke(message);
	}
	public bool AddSubsriber(Action<string> newSubs)
	{
		if (mySubs is null)
		
		{
			mySubs = newSubs;
			return true;
		}
		else if (mySubs.GetInvocationList().Contains(newSubs))
		
		{
			return false;
		}
		else
		
		{
			mySubs +=newSubs;
			return true;
		}
	}
}

class SubscriberAction

{
	string ID =null!;
	public SubscriberAction(string myID)
	{
		ID = myID;
	}
	
	public void GetNotification(string message)
	{
		Console.WriteLine($"SubscriberAction {ID}, {message}");
	}
}
