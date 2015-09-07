using System;

namespace Colors
{
	public class ForCLI
	{
		public ForCLI ()
		{
		}
		public void Default()
		{ Console.ForegroundColor = ConsoleColor.DarkCyan;
		}
		public void prompt(){
			Console.ForegroundColor = ConsoleColor.Green;
		}
		public void Command(){
			Console.ForegroundColor = ConsoleColor.DarkYellow ;
		}
		public void Result(){
			Console.ForegroundColor = ConsoleColor.Yellow;
		}
	}
}

