using System;

namespace PatternsGof.TemplateMethod
{
	public class JavaDeveloper : IDeveloper
	{
		public void Write()
		{
			Console.WriteLine("I'm write with java");
		}
	}
}
