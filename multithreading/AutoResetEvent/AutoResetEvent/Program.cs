using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutoResetEventNS
{
	class Program
	{
		public static AutoResetEvent are = new AutoResetEvent(false);
		public static void Main(string[] args)
		{
			Console.WriteLine("Главный поток выполняет какую-то работу");
			new ClassA(are);
			Console.WriteLine("Ожидаем от потока A сигнал о том, что можно продолжить");
			are.WaitOne();
			Console.WriteLine("Сигнал от потока А получен. Продолжаем работу");


			new ClassB(are);
			Console.WriteLine("Ожидаем от потока B сигнал о том, что можно продолжить");
			are.WaitOne();
			Console.WriteLine("Сигнал от потока B получен. Продолжаем работу");
			Console.ReadLine();
		}
	}
	class ClassA
	{
		AutoResetEvent are;
		public ClassA(AutoResetEvent are)
		{
			this.are = are;
			new Thread(GO).Start();
		}
		private void GO()
		{
			Console.WriteLine("Поток в классе A начал работу");
			Thread.Sleep(20000);
			Console.WriteLine("Поток в классе А закончил работу");
			are.Set(); // Передаем сигнал, что можно продажить кто ожитает
		}
	}
	class ClassB
	{
		AutoResetEvent are;
		public ClassB(AutoResetEvent are)
		{
			this.are = are;
			new Thread(GO).Start();
		}
		private void GO()
		{
			Console.WriteLine("Поток в классе В начал работу");
			Thread.Sleep(15000);
			Console.WriteLine("Поток в классе В закончил работу");
			are.Set(); // Передаем сигнал, что можно продажить кто ожитает
		}

	}
}
