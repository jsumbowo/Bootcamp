// See https://aka.ms/new-console-template for more information
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;
using Day03;
using Encapsulation;

class Program
{
	static void Main()
	{
		BaseOveriding baseOveriding = new GrandChildOveriding();
		baseOveriding.Demo();
		Console.WriteLine(baseOveriding.id);
	}
}




