using System;

namespace PatternsGof.Strategy
{
	public class FullSearch : IStrategy
	{
		public void Search()
		{
			Console.WriteLine("Full search");
		}
	}
}
