namespace PatternsGof.Builder.Abstract
{
	public interface IBuilder
	{
		void BuildFoundatiton(string foundation);
		void BuildWall(string wall);
		void BuildRoof(string roof);

		IProduct GetProduct();
	}
}
