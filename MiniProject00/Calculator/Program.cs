using System;

namespace Calculator
{
	class MainClass
	{
		//Defining Libraries
		public Userinput.Uinput uInput=new Userinput.Uinput ();
		public static void Main (string[] args)
		{
			Console.WriteLine ("Hello World!");
			MainClass _program = new MainClass ();
			_program.uInput.justesting ();
		}
	}
}
