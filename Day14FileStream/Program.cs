class Program
{
	static void Main()
	
	{
		//How to strem ? 
		// 1. choose the path of the file 
		string path = @"./text.txt";
		// 2. Create FileStram to do streaming 
		using (FileStream fs = new FileStream(path, FileMode.Create, FileAccess.ReadWrite, FileShare.Write))
		
		{
			// 3. Create StreamWriter to write text on your file 
			StreamWriter sw = new StreamWriter(fs);
			Console.WriteLine("What is your message ?");
			string message = Console.ReadLine();
			sw.Write(message);
			sw.Close();
			
			// 4. Create StreamReader to read the file 
			StreamReader sr = new StreamReader(path);
			sr.BaseStream.Seek(0, SeekOrigin.Begin);
			Console.WriteLine(sr.ReadLine());
		}
	}
}
