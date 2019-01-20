
// Proxy pattern -- Structural example 

//-------------------------------------------------
//	This structural code demonstrates the Proxy pattern which provides a 
//	representative object (proxy) that controls access to another similar object. 
//
//	Output 
//	Called RealSubject.Request() 
//-------------------------------------------------

using System;

namespace DoFactory.GangOfFour.Proxy.Structural
{
  
	// MainApp test application 

	class MainApp
	{
		static void Main()
		{
			// Create proxy and request a service 
			Proxy proxy = new Proxy();
			proxy.Request();

			// Wait for user 
			Console.Read();
		}
	}

	// "Subject" 

	abstract class Subject 
	{
		public abstract void Request();    
	}

	// "RealSubject" 

	class RealSubject : Subject
	{
		public override void Request()
		{
			Console.WriteLine("Called RealSubject.Request()");
		}
	}

	// "Proxy" 

	class Proxy : Subject
	{
		RealSubject realSubject;

		public override void Request()
		{
			// Use 'lazy initialization' 
			if (realSubject == null)
			{
				realSubject = new RealSubject();
			}

			realSubject.Request();
		}  
	}
}





