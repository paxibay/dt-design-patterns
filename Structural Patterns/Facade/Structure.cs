
// Facade pattern -- Structural example 

//-------------------------------------------------
//	This structural code demonstrates the Facade pattern which provides a 
//	simplified and uniform interface to a large subsystem of classes. 
//
//	Output 
//	MethodA() ----
//	SubSystemOne Method
//	SubSystemTwo Method
//	SubSystemFour Method
//
//	MethodB() ----
//	SubSystemTwo Method
//	SubSystemThree Method
//-------------------------------------------------

using System;

namespace DoFactory.GangOfFour.Facade.Structural
{

	// Mainapp test application 

	class MainApp
	{
		public static void Main()
		{
			Facade facade = new Facade();

			facade.MethodA();
			facade.MethodB();

			// Wait for user 
			Console.Read();
		}
	}

	// "Subsystem ClassA" 

	class SubSystemOne
	{
		public void MethodOne()
		{
			Console.WriteLine(" SubSystemOne Method");
		}
	}

	// Subsystem ClassB" 

	class SubSystemTwo
	{
		public void MethodTwo()
		{
			Console.WriteLine(" SubSystemTwo Method");
		}
	}

	// Subsystem ClassC" 

	class SubSystemThree
	{
		public void MethodThree()
		{
			Console.WriteLine(" SubSystemThree Method");
		}
	}

	// Subsystem ClassD" 

	class SubSystemFour
	{
		public void MethodFour()
		{
			Console.WriteLine(" SubSystemFour Method");
		}
	}

	// "Facade" 

	class Facade
	{
		SubSystemOne one;
		SubSystemTwo two;
		SubSystemThree three;
		SubSystemFour four;

		public Facade()
		{
			one = new SubSystemOne();
			two = new SubSystemTwo();
			three = new SubSystemThree();
			four = new SubSystemFour();
		}

		public void MethodA()
		{
			Console.WriteLine("\nMethodA() ---- ");
			one.MethodOne();
			two.MethodTwo();
			four.MethodFour();
		}

		public void MethodB()
		{
			Console.WriteLine("\nMethodB() ---- ");
			two.MethodTwo();
			three.MethodThree();
		}
	}
}

 
