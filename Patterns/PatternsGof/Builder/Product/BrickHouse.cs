using PatternsGof.Builder.Abstract;
using System;

namespace PatternsGof.Builder
{
	public class BrickHouse : IProduct
	{
		public string Foundatiton { get; set; }
		public string Wall { get; set; }
		public string Roof { get; set; }
	}
}
