using PatternsGof.AbstractFactory.Abstract;
using PatternsGof.AbstractFactory.CSharp;
using PatternsGof.AbstractFactory.Java;
using System;

namespace PatternsGof.AbstractFactory
{
	public class ClientAbstractFactory
	{
		public void Go()
		{
			Product product = new JavaProduct();
			product.Create();
			Console.WriteLine("==================");
			product = new CSharpProduct();
			product.Create();
		}
	}
}
