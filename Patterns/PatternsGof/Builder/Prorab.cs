using PatternsGof.Builder.Abstract;

namespace PatternsGof.Builder
{
	public class Prorab
	{
		readonly IBuilder builder;
		public Prorab(IBuilder builder)
		{
			this.builder = builder;
		}

		public IProduct GetProduct()
		{
			return builder.GetProduct();
		}
	}
}
