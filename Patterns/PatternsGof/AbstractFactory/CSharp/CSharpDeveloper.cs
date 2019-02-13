using PatternsGof.AbstractFactory.Abstract;
using System;

namespace PatternsGof.AbstractFactory.CSharp
{
	public class CSharpDeveloper : IDeveloper
	{
		public void Write()
		{
			Console.WriteLine("I'm a c# developer");
		}
	}
}
