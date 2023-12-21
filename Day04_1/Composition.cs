class Engine
{
	public int cylinder;
	public virtual void StartEngine()
	{
		Console.WriteLine("The engine in on...");
	}
	
	public Engine(int carCyclinder)
	{
		cylinder = carCyclinder;
		Console.WriteLine("The engine is made");
	}
	public Engine()
	{
		
	}
}

class Lamp
{
	public int lux;
	public void LampOn()
	{
		Console.WriteLine("The lamp is on !!!");
	}
	public Lamp(int lampLux)
	{
		lux = lampLux;
		Console.WriteLine("The lamp is made");
	}
}

class Car
{
	Engine engine;
	Lamp lamp;
	public Car(Engine carEngine, Lamp carLamp)
	{
		engine = carEngine;
		lamp = carLamp;
		Console.WriteLine("The car is made");
	}
	
	public void CarOn()
	{
		engine.StartEngine();
		lamp.LampOn();
	}
	
	public void CarStatus()
	{
		Console.WriteLine("Car cylinder: "+engine.cylinder);
		Console.WriteLine("Car lamp lux: " + lamp.lux);
	}
}

class ElectricEngine : Engine 
{
	int batteryHealth = 100;
	public override void StartEngine()
	{
		Console.WriteLine("The electric engine is on !!!");
		Console.WriteLine("Battery Health: " + batteryHealth + " %");
	}
	public ElectricEngine()
	{
		cylinder = 0;
		Console.WriteLine("The electric engine is made");
	}
}