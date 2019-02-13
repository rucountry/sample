using PatternsGof.AbstractFactory.Abstract;
using System;

namespace PatternsGof.AbstractFactory.Java
{
	public class JavaDeveloper : IDeveloper
	{
		public void Write()
		{
			Console.WriteLine("I'm a java developer");
		}
	}
}
