using System;

namespace PatternsGof.Strategy.Delegate
{
	public class SearchStrategyDelegate
	{
		private Func<int, string> func;
		public SearchStrategyDelegate(Func<int,string> func)
		{
			this.func = func;
		}

		public void Parse()
		{
			Console.WriteLine(func(1));
		}
	}
}
