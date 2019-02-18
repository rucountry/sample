using PatternsGof.Builder;
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

			//ClientSingleton client = new ClientSingleton();
			//client.Go();

			ClientBuilder client = new ClientBuilder();
			client.Go();

			Console.ReadLine();
		}
	}
}
