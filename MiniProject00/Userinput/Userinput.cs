using System;

namespace Userinput
{
	public class Uinput	
	{
		public About.about me=new About.about();
		Colors.ForCLI c=new Colors.ForCLI();
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
				if(_comm.ToLower().Contains("command1")){ c.Default();
					Console.Write("You've started \n");
					c.Result();Console.WriteLine(" command1");
				}
				if(_comm.ToLower().Contains("command2")) Console.Write("You've started command2\n");
				if(_comm.ToLower().Contains("command3")) Console.Write("You've started command3\n");
			} while((_comm.ToLower() != "quit") && (_comm.ToLower() !="leave") && (_comm.ToLower()!="exit"));
		}
		public void justesting()
		{
			Console.WriteLine ("startin Userinput.Uinput.justesting()");
		}
	}
}

