using PatternsGof.AbstractFactory.Abstract;
using System;

namespace PatternsGof.AbstractFactory.CSharp
{
	public class CSharpTester : ITester
	{
		public void Write()
		{
			Console.WriteLine("testing c#");
		}
	}
}
