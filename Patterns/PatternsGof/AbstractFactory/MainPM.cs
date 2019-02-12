using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsGof.AbstractFactory
{
	public class MainPM : Ipm
	{
		public void Write()
		{
			Console.WriteLine("I'm a main project manager");
		}
	}
}
