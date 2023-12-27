// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography.X509Certificates;

class Program
{
	static void Main ()
	{
		GameController myGameController = new();
		Console.WriteLine("Game status is: " + myGameController.CheckGame());
		myGameController.AddPlayer(new Beginer("Joel"));
		Console.WriteLine("Game status is: " + myGameController.CheckGame());
		Console.WriteLine("Player Name: " + myGameController.CheckPlayerName());
		
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

class GameController
{
	private GameStatus _gameStatus;
	private IPlayer _player;
	
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
		if (_gameStatus == GameStatus.NotInitialized)
		
		{
			return false;
		}
		_player = player;
		_gameStatus = GameStatus.Ready;
		return true;
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


