using System.Data;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

class program
{
	static void Main()
	
	{
		//Serialization with JSON only happen to class with Property value(not variable)
		Person person = new Person(){Name = "yanti", Id = 1};
		DataContractJsonSerializer serializer = new(typeof(Person));
		using(FileStream fs = new(@"./person.json", FileMode.OpenOrCreate))
		
		{
			serializer.WriteObject(fs, person);
		}
		
		Person importPerson; 
		using(FileStream fs = new(@"./person.json", FileMode.Open))
		
		{
			importPerson = (Person)serializer.ReadObject(fs);
		}
		Console.WriteLine(importPerson.Name);
		
	}
}

// For choosing property
[DataContract]
public class Person
{
	//Data member for choosing property that is going to be serialized
	[DataMember]
	public string Name{get; set;}
	[DataMember]
	public int Id{get; set;}
}