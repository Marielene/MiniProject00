using System;

namespace Calculations
{
	public class MainLibrary
	{
		//Definitions
		public Formula01 F01=new Formula01();
		public Formula02 F02=new Formula02();
		public Formula03 F03=new Formula03();
		public Formula04 F04=new Formula04();
		public Formula05 F05=new Formula05();
		//Libraries
		private Colors.ForCLI _cl=new Colors.ForCLI();
		public MainLibrary ()
		{
		}

		public void commadns(){
			_cl.help ();
			Console.WriteLine ("Available commands:\n \n");
			Console.Write ("[pit]"); Console.WriteLine ("- calculating the volume of an ordinary construction pit");
			Console.Write ("[ccorner]"); Console.WriteLine ("- calculating the volume of a concave corner.");
			Console.Write ("[salient]"); Console.WriteLine ("- calculating the volume of a salient.");
			Console.Write ("[scorner]"); Console.WriteLine ("- calculating the volume of a side corner.");
			Console.Write ("[trench]"); Console.WriteLine ("- calculating the volume of a channel trench.\n");
		}
	}
}

