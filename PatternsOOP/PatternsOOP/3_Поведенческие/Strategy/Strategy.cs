using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsOOP.Strategy
{
	public interface IDrink
	{
		void Open();
	}

	public class Pepsi : IDrink
	{
		public void Open()
		{
			Console.WriteLine("Откручиваем крышку по часовой стрелке!!!");
		}
	}
	public class CocaCola : IDrink
	{
		public void Open()
		{
			Console.WriteLine("Откручиваем крышку против часовой стрелке!!!");
		}
	}
	public class People
	{
		IDrink drink;
		public People(IDrink drink)
		{
			this.drink = drink;
		}
		public void Drink()
		{
			drink.Open();
		}
	}
	class ClientStrategy
	{
		public void Run()
		{
			People people = new People(new CocaCola());
			people.Drink();

			people = new People(new Pepsi());
			people.Drink();
		}
	}
}
