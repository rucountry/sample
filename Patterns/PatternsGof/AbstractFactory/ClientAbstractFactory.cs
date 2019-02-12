using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsGof.AbstractFactory
{
	public class ClientAbstractFactory
	{
		public void Go()
		{
			Product product = new JavaProduct();
			product.Create();
			Console.WriteLine("==================");
			product = new PhpProduct();
			product.Create();
		}
	}
}
