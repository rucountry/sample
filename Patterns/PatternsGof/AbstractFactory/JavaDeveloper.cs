using System;

namespace PatternsGof.AbstractFactory
{
	public class JavaDeveloper : IDeveloper
	{
		public void Write()
		{
			Console.WriteLine("I'm a java developer");
		}
	}
}
