using System.Security.Cryptography;

namespace Day05;

public class EducationChecker
{
	public EducationChecker(Student student)
	{
		Console.WriteLine(student.HighSchool());
		Console.WriteLine(student.Collage());
	}
}

public abstract class Student 
{
	public string name ;
	public int age;
	
	public Student(string myName, int myAge)
	{
		name = myName;
		age = myAge;
	}
	public abstract string HighSchool();
	public abstract string Collage();
}

class SurabayaStudent : Student
{
	public SurabayaStudent(string myName, int myAge) : base (myName, myAge)
	{
		Console.WriteLine("Name: " + name);
		Console.WriteLine("Age: " + age);
	}
	public override string HighSchool()
	{
		return "SMAN 5 Surabaya";
	}
	public override string Collage()
	{
		return "UNIAR";
	}
}

class BandungStudent : Student
{
	public BandungStudent(string myName, int myAge) : base (myName, myAge)
	{
		Console.WriteLine("Name: " + name);
		Console.WriteLine("Age: " + age);
	}
	public override string HighSchool()
	{
		return "SMAN 3 Bandung";
	}
	public override string Collage()
	{
		return "ITB";
	}
}
