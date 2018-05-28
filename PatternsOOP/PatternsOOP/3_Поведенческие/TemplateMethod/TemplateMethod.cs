using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsOOP.TemplateMethod
{
	public abstract class ProductWater
	{
		public abstract void Water();
		public abstract void Bottle();
		public abstract void Label();

		public void TemplateMethod()
		{
			Water();
			Bottle();
			Label();
		}
	}

	public class CocaCola : ProductWater
	{
		public override void Bottle()
		{
			Console.WriteLine("Берем бутылку coca-cola");
		}

		public override void Label()
		{
			Console.WriteLine("Берем этикетку coca-cola");
		}

		public override void Water()
		{
			Console.WriteLine("Наливаем coca-cola");
		}
	}
	public class PepsiCola : ProductWater
	{
		public override void Bottle()
		{
			Console.WriteLine("Берем бутылку pepsi cola");
		}

		public override void Label()
		{
			Console.WriteLine("Берем этикетку pepsi cola");
		}

		public override void Water()
		{
			Console.WriteLine("Наливаем pepsi cola");
		}
	}


	class ClientTemplateMethod
	{
		public void Run()
		{
			ProductWater water = new CocaCola();
			water.TemplateMethod();

			new PepsiCola().TemplateMethod();
		}
	}
}
