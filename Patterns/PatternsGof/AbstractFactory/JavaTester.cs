using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsGof.AbstractFactory
{
	public class JavaTester : ITester
	{
		public void Write()
		{
			Console.WriteLine("Testing java code!!!");
		}
	}
}
