using PatternsGof.Builder.Abstract;
using System;

namespace PatternsGof.Builder
{
	public class ClientBuilder
	{
		Prorab prorab;
		public ClientBuilder()
		{
			prorab = new Prorab(new TreeBuilder());
		}

		public void Go()
		{
			IProduct product = prorab.GetProduct();
			Console.WriteLine(product.Foundatiton);
			Console.WriteLine(product.Wall);
			Console.WriteLine(product.Roof);
			Console.WriteLine("----------------------");
			prorab = new Prorab(new BrickBuilder());
			product = prorab.GetProduct();
			Console.WriteLine(product.Foundatiton);
			Console.WriteLine(product.Wall);
			Console.WriteLine(product.Roof);
		}
	}
}
