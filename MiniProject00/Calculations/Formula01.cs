using System;

namespace Calculations
{
	public class Formula01
	{
		private Colors.ForCLI c=new Colors.ForCLI();
		public Formula01 () //F(x) for a simple building site hole
		{
		}
		//Parse
		public void calc(string ui)
		{
			try {
				string[] par=ui.Split(' ');
				if(par.Length>1 && ui.ToLower().Contains("-h")){
					//Help for the commands.	
					c.help();Console.Write("[hole]");
					Console.WriteLine("- command for a simple rectangular building site hole.\n");

					Console.Write("parameters:");
					Console.WriteLine("a1, b1, a2, b2, h\n");

					Console.Write("a1 and b1");
					Console.WriteLine("- width and length of the hole in the top part.");

					Console.Write("a2 and b2");
					Console.WriteLine("- width and length of the hole in the bottom part.");

					Console.Write("h");
					Console.WriteLine("- depth of the entire thing.");

				}
				if(par.Length>1 && !ui.ToLower().Contains("-h")){
					//Calculations	
					double _result =0;
					if (runcalc(par, ref _result))
					{
						c.Default();Console.WriteLine("Volume of the hole is: ");
						c.Result();Console.WriteLine(_result+"m3");
					}
					else{ c.Error();Console.WriteLine("Invalid input, use the help command");
					}
				}
			} catch {}
		}
		//Print result
		private bool runcalc(string[] _param, ref double _result)
		{
			try{
				double a1=0, b1=0, a2=0, b2=0, _h=0;
				double.TryParse(_param[1], out a1);
				double.TryParse(_param[2], out b1);
				double.TryParse(_param[3], out a2);
				double.TryParse(_param[4], out b2);
				double.TryParse(_param[0], out _h);
				double F1=a1*b1, F2=a2*b2;
				_result=_h*F1+F2/2;
				return true;
			}catch{}
			_result = 0;
			return false;
		}
		//Help
	}
}

