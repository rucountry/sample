namespace PatternsGof.Strategy
{
	public class SearchStrategy
	{
		readonly IStrategy strategy;
		public SearchStrategy(IStrategy strategy)
		{
			this.strategy = strategy;
		}

		public void Search()
		{
			strategy.Search();
		}
	}
}
