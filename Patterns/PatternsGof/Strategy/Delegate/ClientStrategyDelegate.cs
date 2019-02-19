using System;

namespace PatternsGof.Strategy.Delegate
{
	class ClientStrategyDelegate
	{
		public void Go()
		{
			Func<int, string> func = new YandexParser().Parser;
			SearchStrategyDelegate client = new SearchStrategyDelegate(func);
			client.Parse();
			Console.WriteLine("==================================");
			client = new SearchStrategyDelegate(new GoogleParser().Parser);
			client.Parse();

		}
	}
}
