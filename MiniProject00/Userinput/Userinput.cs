using System;

namespace Userinput
{
	public class Uinput	
	{
		public About.about me=new About.about();
		Colors.ForCLI c=new Colors.ForCLI();
		Calculations.MainLibrary _Calc=new Calculations.MainLibrary();
		public Uinput ()
		{
		}
		public void ey(){
			c.Default ();Console.WriteLine ("Welcome in\n" + me.shortname + "\n" + me.versio+ "\n\n");
		}
		public void getusercomm(){
			string _comm = "";
			do {
				//taking commands
				c.prompt();Console.Write("$ "); 
				c.Command();_comm=Console.ReadLine();
				//checking for existing commands
				if(_comm.ToLower().Contains("pit")) _Calc.F01.calc(_comm);
				if(_comm.ToLower().Contains("corner")) _Calc.F02.cal(_comm);
				if(_comm.ToLower().Contains("salient")) _Calc.F03.cali(_comm);
				if(_comm.ToLower().Contains("help")||
					_comm.ToLower()==("-h")) _Calc.commadns();
				if(_comm.ToLower()==("clear")||
					_comm.ToLower()==("-c")) {
					Console.Clear();
					c.Default ();Console.WriteLine ("Welcome in\n" + me.shortname + "\n" + me.versio+ "\n\n");
				}
			} while((_comm.ToLower() != "quit") && (_comm.ToLower() !="leave") && (_comm.ToLower()!="exit"));
		}
		public void justesting()
		{
			Console.WriteLine ("startin Userinput.Uinput.justesting()");
		}
	}
}

