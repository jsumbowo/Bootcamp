class Program
{
	static void Main()
	{
		#if ANDROID
		#region android
		Console.WriteLine("Android");
		#endregion
		#elif YANTO
		Console.WriteLine("YANTO");
		#elif APPLE
		Console.WriteLine("Apple");
		#endif
		
	}
}