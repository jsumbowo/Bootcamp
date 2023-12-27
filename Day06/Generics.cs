// <T>
class MyCollection<T>
{
	public T[] myCollection;
	public int count;

	public MyCollection(int size)
	{
		myCollection = new T[size];
		count = -1;
	}
	public bool AddObject(T obj)
	{
		if (count == myCollection.Length - 1)
		{
			return false;
		}
		count++;
		myCollection[count] = obj;
		return true;
	}
	public T GetData(int index)
	{
		if (index > myCollection.Length - 1)
		{
			return default;
		}
		return myCollection[index];
	}

}
