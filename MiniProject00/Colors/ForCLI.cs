using System;

namespace Colors
{
	public class ForCLI
	{
		public ForCLI ()
		{
		}
		public void Default()
		{ Console.ForegroundColor = ConsoleColor.Cyan;
		}
		public void prompt(){
			Console.ForegroundColor = ConsoleColor.Cyan;
		}
		public void Command(){
			Console.ForegroundColor = ConsoleColor.DarkCyan ;
		}
		public void Result(){
			Console.ForegroundColor = ConsoleColor.Green;
		}
		public void Error(){
			Console.ForegroundColor = ConsoleColor.Red;
		}
		public void help(){
			Console.ForegroundColor = ConsoleColor.Magenta;
		}
	}
}

