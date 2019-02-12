using System;

namespace PatternsGof.AbstractFactory
{
	public class PhpDeveloper : IDeveloper
	{
		public void Write()
		{
			Console.WriteLine("I'm a php developer");
		}
	}
}
