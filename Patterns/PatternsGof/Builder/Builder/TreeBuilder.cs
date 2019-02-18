using PatternsGof.Builder.Abstract;

namespace PatternsGof.Builder
{
	public class TreeBuilder : IBuilder
	{
		readonly TreeHouse product;
		public TreeBuilder()
		{
			product = new TreeHouse();
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
			BuildWall("Строим деревянные стены");
			BuildRoof("Строим крышу из дерева");
			return product;
		}
	}
}
