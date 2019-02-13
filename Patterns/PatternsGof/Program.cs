using PatternsGof.AbstractFactory;
using PatternsGof.Singleton;
using PatternsGof.TemplateMethod;
using System;

namespace PatternsGof
{
	class Program
	{
		static void Main(string[] args)
		{
			//ClientTemplateMethod client = new ClientTemplateMethod();
			//client.Go();

			//ClientAbstractFactory client = new ClientAbstractFactory();
			//client.Go();

			ClientSingleton client = new ClientSingleton();
			client.Go();

			Console.ReadLine();
		}
	}
}
