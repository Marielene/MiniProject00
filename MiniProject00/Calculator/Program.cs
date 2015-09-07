using System;

namespace Calculator
{
	class MainClass
	{
		//Defining Libraries
		public Userinput.Uinput uInput=new Userinput.Uinput ();
		public About.about me=new About.about();
		public static void Main (string[] args)
		{
			MainClass _program = new MainClass ();
			_program.uInput.ey ();
			_program.uInput.getusercomm ();
		}
	}
}
