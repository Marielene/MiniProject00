using System;

namespace Calculations
{
	public class Formula01
	{
		private Colors.ForCLI c=new Colors.ForCLI();
		public Formula01 () //F(x) for an ordinary construction pit
		{
		}
		//Parse
		public void calc(string ui)
		{
			try {
				string[] par=ui.Split(' ');
				if(par.Length>1 && ui.ToLower().Contains("-h")){
					//Help for the commands.	
					c.help();Console.Write("[pit]");
					Console.WriteLine("- cordinary construction pit\n");

					Console.Write("parameters:");
					Console.WriteLine("a1, b1, a2, b2, h\n");

					Console.Write("a1 and b1");
					Console.WriteLine("- width and length of the pit in the top part.");

					Console.Write("a2 and b2");
					Console.WriteLine("- width and length of the pit in the bottom part.");

					Console.Write("h");
					Console.WriteLine("- depth of the entire thing.");

				}
				if(par.Length>1 && !ui.ToLower().Contains("-h")){
					//Calculations	
					double _result =0;
					if (runcalc(par, ref _result))
					{
						c.Result();Console.WriteLine("Volume of the ordinary construction pit is: ");
						Console.WriteLine(_result+"m3");
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
				double.TryParse(_param[5], out _h);
				_result=_h*(a1*b1+a2*b2)/2;
					return true;
			}catch{}
			_result = 0;
			return false;
		}
		//Help
	}
}

