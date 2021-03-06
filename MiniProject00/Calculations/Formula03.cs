﻿using System;

namespace Calculations
{
	public class Formula03
	{
		private Colors.ForCLI c=new Colors.ForCLI();
		public Formula03 ()
		{
		}

		public void cali(string _input){
			try{
				string[] param=_input.Split(' ');
				if(param.Length>1 && _input.Contains("-h")){
					c.help(); help();
				}
				double _result=0;
				if(param.Length==4 && angle1(param,out _result)){
					c.Result();Console.WriteLine("The Volume of the salient is: " + _result + "m3");
				}
				else if(!_input.Contains("-h")){c.Error(); Console.WriteLine("Invalid input, use command + -h for help.\n");} 
			}catch{
			}
		}
		private bool angle1(string[] _param, out double _result){
			try{
				double a= 0; Double.TryParse(_param[1], out a);
				double b= 0; Double.TryParse(_param[2], out b);
				double h= 0; Double.TryParse(_param[3], out h);
				_result=a*b*h*2/3;
				return true;
			}catch{
			}
			_result = 0;
			return false;
		}

		private void help(){
			Console.Write ("[salient]");
			Console.WriteLine ("- convex corner;\n");

			Console.Write ("parameters:");
			Console.WriteLine ("a, b, and h;\n");

			Console.Write ("a and b");
			Console.WriteLine ("- width and length;\n");

			Console.Write ("h");
			Console.WriteLine ("- height;\n");

		}
	}
}

