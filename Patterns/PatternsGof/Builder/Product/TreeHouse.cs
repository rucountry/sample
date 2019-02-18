using PatternsGof.Builder.Abstract;

namespace PatternsGof.Builder
{
	public class TreeHouse : IProduct
	{
		public string Foundatiton { get; set; }
		public string Wall { get; set; }
		public string Roof { get; set; }
	}
}
