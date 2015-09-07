using System;

namespace Calculator
{
	public class Formula01
	{
		public Formula01 () //Formula for usual digging
		{
		}
		//Parsing
		public void calc(string _userInput)
		{
			try {
				string[] param = _userInput.Split (' ');
				if (param.Length>1 && _userInput.Contains ("help"))
				{
					//HALP
				}
				if (param.Length>1 && !_userInput.Contains ("help"))
				{
					//wot do??
				}
			} catch {
			}

		}
		//Calculating and printing
		private bool runcalc()

		//help for command
	}
}

