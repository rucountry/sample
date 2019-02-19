using System;

namespace PatternsGof.Strategy
{
	public class ClientStrategy
	{
		public void Go()
		{
			IStrategy strategy = new FullSearch();
			SearchStrategy searchStrategy = new SearchStrategy(strategy);
			searchStrategy.Search();
			Console.WriteLine("===============");
			strategy = new FastSearch();
			searchStrategy = new SearchStrategy(strategy);
			searchStrategy.Search();
		}
	}
}
