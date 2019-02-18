using System;

namespace PatternsGof.TemplateMethod
{
	public class CSharpDeveloper : IDeveloper
	{
		public void Write()
		{
			Console.WriteLine("I'm write with c#");
		}
	}
}
