using PatternsGof.Builder.Abstract;

namespace PatternsGof.Builder
{
	public class BrickBuilder : IBuilder
	{
		readonly BrickHouse product;
		public BrickBuilder()
		{
			product = new BrickHouse();
		}
		public void BuildFoundatiton(string foundation)
		{
			product.Foundatiton = foundation;
		}

		public void BuildRoof(string roof)
		{
			product.Roof = roof;
		}

		public void BuildWall(string wall)
		{
			product.Wall = wall;
		}

		public IProduct GetProduct()
		{
			BuildFoundatiton("Закладываем кирпичный фундамент");
			BuildWall("Строим кирпичные стены");
			BuildRoof("Строим крышу из черепицы");
			return product;
		}
	}
}
