using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsGof.AbstractFactory
{
	public class CSharpTester : ITester
	{
		public void Write()
		{
			Console.WriteLine("testing c#");
		}
	}
}
