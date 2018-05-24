using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsOOP.Observer
{
	public interface IObserver
	{
		string Name { get; }
		void Update(string info);
	}

	public interface IObservable
	{
		void Add(IObserver o);
		void Delete(IObserver o);
		void Notify();
	}

	// Издатель газет
	public class Publisher : IObservable
	{
		private List<IObserver> _list;

		public Publisher()
		{
			_list = new List<IObserver>();
		}

		public void Add(IObserver o)
		{
			_list.Add(o);
		}

		public void Delete(IObserver o)
		{
			_list.Remove(o);
		}

		public void Notify()
		{
			for (int i = 0; i < _list.Count; i++)
			{
				_list[i].Update("Новый журнал вышел в " + DateTime.Now + " для " + _list[i].Name);
			}
		}
	}
	// Подписчик
	public class Subscriber : IObserver
	{
		private string _name;
		public Subscriber(string name)
		{
			_name = name;
		}
		public string Name { get { return _name; } }
		public void Update(string info)
		{
			Console.WriteLine(info);
		}
	}

	class ClientObserver
	{
		public void Run()
		{
			IObservable publisher = new Publisher();
			IObserver o1 = new Subscriber("Иван");
			IObserver o2 = new Subscriber("Петр");

			publisher.Add(o1);
			publisher.Add(o2);
			publisher.Notify();
			Console.WriteLine("-----------------------");
			publisher.Delete(o2);
			publisher.Notify();

		}
	}
}
