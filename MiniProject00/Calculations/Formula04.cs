using System;

namespace Calculations
{
	public class Formula04
	{
		private Colors.ForCLI c=new Colors.ForCLI();
		public Formula04 ()
		{
		}
		public void call(string _input){
			try{
				string[] param=_input.Split(' ');
				if(param.Length>1 && _input.Contains("-h")){
					c.help(); help();
				}
				double _result=0;
				if(param.Length==4 && angle2(param,out _result)){
					c.Result();Console.WriteLine("The Volume of the salient is: " + _result + "m3");
				}
				else if(!_input.Contains("-h")){c.Error(); Console.WriteLine("Invalid input, use command + -h for help.\n");} 
			}catch{
			}
		}
		private bool angle2(string[] _param, out double _result){
			try{
				double a= 0; Double.TryParse(_param[1], out a);
				double h= 0; Double.TryParse(_param[2], out h);
				double L= 0; Double.TryParse(_param[3], out L);
				_result=(a*h/2)*L;
				return true;
			}catch{
			}
			_result = 0;
			return false;
		}

		private void help(){
			Console.Write ("[scorner]");
			Console.WriteLine ("- side corner;\n");

			Console.Write ("parameters:");
			Console.WriteLine ("a, h, and L;\n");

			Console.Write ("a and h");
			Console.WriteLine ("- width and height;\n");

			Console.Write ("L");
			Console.WriteLine ("- length;\n");

		}
	}
}

