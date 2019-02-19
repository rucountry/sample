using System;

namespace PatternsGof.Strategy
{
	public class FastSearch : IStrategy
	{
		public void Search()
		{
			Console.WriteLine("Fast search");
		}
	}
}
