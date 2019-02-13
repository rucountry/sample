using PatternsGof.AbstractFactory.Abstract;
using System;

namespace PatternsGof.AbstractFactory.CSharp
{
	public class MainPM : Ipm
	{
		public void Write()
		{
			Console.WriteLine("I'm a main project manager");
		}
	}
}
