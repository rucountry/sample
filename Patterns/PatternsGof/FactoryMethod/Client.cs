using System;

namespace PatternsGof.TemplateMethod
{
	public class ClientTemplateMethod
	{
		public void Go()
		{
			IFactory factory = new CSharpFactory();
			IDeveloper developer = factory.CreateDeveloper();
			developer.Write();

			Console.WriteLine("==============");

			factory = new JavaFactory();
			developer = factory.CreateDeveloper();
			developer.Write();
		}
	}
}
