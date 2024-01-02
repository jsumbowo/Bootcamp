using System;
using System.Collections;
class Program
{
	static void Main()
	
	{
		Beginer beginer = new Beginer();
		beginer.Greet();
		List<int> myList = new List<int>();
		HashSet<int> hashOne = new HashSet<int>();
		
		for (int i= 1; i<=3 ; i++)
		
		{
			hashOne.Add(i);
		}
		
		HashSet<int> hashTwo = new HashSet<int>(){2, 3, 4};
		// 3.Dump();
		hashOne.TryGetValue(3, out int value);
		foreach (int hash in hashOne)

		{
			hash.Dump();
		}
		//Queue is FIFO 
		Queue<int> queue = new Queue<int>();
		queue.Enqueue(3);
		queue.Enqueue(4);
		int result = queue.Dequeue(); //untuk ngambil
		Console.WriteLine(queue.Peek()); //untuk ngeliat aja ga ngambil
		//Stack is LIFO
		Stack<int> stack = new Stack<int>();
		stack.Push(2);
		stack.Push(3);
		int resultStack = stack.Pop();
		Console.WriteLine(stack.Peek());
	}
}

abstract class Player
{
	public abstract void Greet();
}

class Beginer : Player

{
	public override void Greet()
	{
		Console.WriteLine("This is Beginer");
	}
}

public static class ResistorColor
{   
	public static int ColorCode(string color)
	{
		string[] resistorColors = Colors();
		foreach (string resistorColor in resistorColors)
		{
			if (resistorColor == color)
			{
				return Array.IndexOf(resistorColors, resistorColor);
			}
		}
		return default;
	}

	public static string[] Colors()
	{
		string[] resistorColors = new string[10] {"Black",
		"Brown", "Red", "Orange", "Yellow", "Green", "Blue", "Violet",
			"Grey", "White"};
		return resistorColors;
	}
}

public static class MyDump
{	public static void Dump(this object myObject)
	
	{
		Console.WriteLine(myObject);
	}
}
