using System;

namespace Calculations
{
	public class Formula05
	{
		private Colors.ForCLI c=new Colors.ForCLI();
		public Formula05 ()
		{
		}
		public void calu(string _input){
			try{
				string[] param=_input.Split(' ');
				if(param.Length>1 && _input.Contains("-h")){
					c.help(); help();
				}
				double _result=0;
				if(param.Length==5 && trench(param,out _result)){
					c.Result();Console.WriteLine("The Volume of the salient is: " + _result + "m3");
				}
				else if(!_input.Contains("-h")){c.Error(); Console.WriteLine("Invalid input, use command + -h for help.\n");} 
			}catch{
			}
		}
		private bool trench(string[] _param, out double _result){
			try{
				double a= 0; Double.TryParse(_param[1], out a);
				double b= 0; Double.TryParse(_param[2], out b);
				double h= 0; Double.TryParse(_param[3], out h);
				double L= 0; Double.TryParse(_param[4], out L);
				_result=(a+b)/2*h*L;
				return true;
			}catch{
			}
			_result = 0;
			return false;
		}

		private void help(){
			Console.Write ("[trench]");
			Console.WriteLine ("- side corner;\n");

			Console.Write ("parameters:");
			Console.WriteLine ("a, b, h and L;\n");

			Console.Write ("a and b");
			Console.WriteLine ("- upper width and lower width;\n");

			Console.Write ("h");
			Console.WriteLine ("- height;\n");

			Console.Write ("L");
			Console.WriteLine ("- length;\n");
	}
}
}

