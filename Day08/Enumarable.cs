
using System.Runtime.CompilerServices;

public class GameController
{
	private List<IPlayer> _player; //Ini tidak dianjurkan karena List mahal secara komputasi
	private IEnumerable<IPlayer> _playerBasic; // Dianjurkan jika kita hanya ingin foreach dari collection player kita
	
	public GameController(IEnumerable<IPlayer> playerBasic)
	
	{
		this._playerBasic = playerBasic;
	}
}

public interface IPlayer
{
	int PlayerID {get;}
	string PlayerName {get;}
}
