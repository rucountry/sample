using PatternsGof.FactoryMethod;
using PatternsGof.Strategy;
using PatternsGof.Strategy.Delegate;
using System;

namespace PatternsGof
{
	class Program
	{
		static void Main(string[] args)
		{
			//ClientFactoryMethod client = new ClientFactoryMethod();
			//client.Go();

			//ClientAbstractFactory client = new ClientAbstractFactory();
			//client.Go();

			//ClientSingleton client = new ClientSingleton();
			//client.Go();

			//ClientBuilder client = new ClientBuilder();
			//client.Go();

			//ClientStrategy client = new ClientStrategy();
			//client.Go();

			ClientStrategyDelegate client = new ClientStrategyDelegate();
			client.Go();

			Console.ReadLine();
		}
	}
}
