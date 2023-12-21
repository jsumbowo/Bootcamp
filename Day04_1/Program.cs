class Program
{
	static void Main ()
	{
		ElectricEngine myelectricEngine = new ElectricEngine();
		Lamp myLamp = new Lamp(20);
		Car myCar = new Car(myelectricEngine, myLamp);
		myCar.CarStatus();
		
	}
}