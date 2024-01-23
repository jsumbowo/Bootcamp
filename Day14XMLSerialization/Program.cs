using System.Reflection;
using System.Runtime.InteropServices;
﻿using System.IO;
using System.Xml.Serialization;
using System.Runtime.Serialization;
class Program
{
	static void Main()
	
	{
		// Serialization is for converting from obj (usually class) to file 
		Person person = new Person() {Name = "Adi", id=1};
		XmlSerializer xmlSerializer = new(typeof(Person));
		
		string path = @"./person.xml";
		using(FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write))
		
		{
			using(StreamWriter sw = new StreamWriter(fs))
			
			{
				xmlSerializer.Serialize(sw, person);
			}
		}
		//Deserialization 
		Person deserializedPerson;
		using (StreamReader reader = new StreamReader("person.xml"))
		{
			deserializedPerson = (Person)xmlSerializer.Deserialize(reader);
		}
		Console.WriteLine(deserializedPerson.Name);
	}
}
// For choosing property
public class Person
{
	//Data member for choosing property that is going to be serialized

	public string Name{get; set;}
	public int id;
}
