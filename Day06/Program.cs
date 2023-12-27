// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography.X509Certificates;
using System.Numerics;


class Program
{
	static void Main ()
	{
		GameController myGameController = new();
		SMS mySMS = new SMS();
		Email myEmail = new Email();
		myGameController.myDelegate += mySMS.SendSMS;
		myGameController.myDelegate += myEmail.SendEmail;
		myGameController.AddPlayer(new Beginer("Joel"));
		// myGameController.MakeReady();
		
		// Console.WriteLine("Game status is: " + myGameController.CheckGame());
		// Console.WriteLine("Player Name: " + myGameController.CheckPlayerName());
		
	}
}

public enum GameStatus
{
	NotInitialized,
	Ready,
	Playing
}

public interface IPlayer
{
	public int ID {get;}
	public string name{get;}
}

class Beginer : IPlayer

{
	public int ID {get; private set;}
	public string name {get; private set;}
	
	public Beginer(string bName)
	{
		ID = 1;
		name = bName;
	}
}

class Intermediate : IPlayer

{
	public int ID {get; private set;}
	public string name {get; private set;}
	
	public Intermediate(string iName)
	{
		ID = 2;
		name = iName;
	}
}

//Making a delegate to communicate to the SMS and Email class
public delegate void MyDelegate(string message);
class GameController
{
	private GameStatus _gameStatus;
	private IPlayer _player;
	
	public MyDelegate myDelegate;
	public GameController()
	{
		_gameStatus = GameStatus.NotInitialized;
	}
	public bool AddPlayer(IPlayer player)
	{
		if (_player != null)
		{
			return false;	
		}
		if (_gameStatus != GameStatus.NotInitialized)
		{
			return false;
		}
		_player = player;
		return true;
	}
	
	public bool MakeReady()
	{
		if (_gameStatus != GameStatus.NotInitialized)
		{
			return false;
		}
		else
		{
			_gameStatus = GameStatus.Ready;
			myDelegate.Invoke("Ready");
			return true;
		}
	}
	
	public GameStatus CheckGame()
	{
		return _gameStatus;
	}
	
	public string CheckPlayerName()
	
	{
		return _player.name;
	}
	
	public int CheckPlayerID()
	
	{
		return _player.ID;
	}
	public bool StartGame()
	{
		if (_gameStatus != GameStatus.Ready)
		{
			return false;
		}
		_gameStatus = GameStatus.Playing;
		return true;
	}
}

// Making an extension method
// 1. Need a static class public 
// 2. Need a static method 
// 3. Using this 

static class MyExtensionMethod
{
	// I want to make an extenstion that can print anything to the console
	public static void Dumb(this object input)
	{
		Console.WriteLine(input);
	}
}

//Generic Constraint
//Generic : All class can set the type
//Constaint : Limit to a class with condition
class Calculator<T> where T:IAdditionOperators<T,T,T>
{
	public T Addition(T a, T b) 
	{
		return a + b;
	}
}

//Operator Overloading
public class Car : IAdditionOperators<Car, Car, Car>
{
	public int price;
	public int year;
	public string name;
	public Car(int price, int year, string name)  
	{
		this.price = price;
		this.year = year;
		this.name = name;
	}
	//Operator Overloading
	public static Car operator +(Car left, Car right) 
	{
		Car resultCar = new Car(left.price+right.price, 0, "");
		return resultCar;
	}
}