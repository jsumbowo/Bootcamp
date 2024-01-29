namespace GClogger;

public class Board : IBoard
{
	private int _size;
	public string name;
	public Board(int size) 
	{
		_size = size;
	}
	public int GetSize()
	{
		return _size;
	}

}

public interface IBoard
{
	int GetSize();
}
