using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ManualResetEventNS
{

	class Program
	{
		public static ManualResetEvent mre = new ManualResetEvent(false);
		static void Main(string[] args)
		{
			Console.WriteLine("Главный поток выполняет какую-то работу");
			new ClassA(mre);
			Console.WriteLine("Ожидаем от потока A сигнал о том, что можно продолжить");
			mre.WaitOne();
			Console.WriteLine("Сигнал от потока А получен. Продолжаем работу");

			mre.Reset(); 

			new ClassB(mre);
			Console.WriteLine("Ожидаем от потока B сигнал о том, что можно продолжить");
			mre.WaitOne();
			Console.WriteLine("Сигнал от потока B получен. Продолжаем работу");
			Console.ReadLine();
		}
	}
	class ClassA
	{
		ManualResetEvent mre;
		public ClassA(ManualResetEvent mre)
		{
			this.mre = mre;
			new Thread(GO).Start();
		}
		private void GO()
		{
			Console.WriteLine("Поток в классе A начал работу");
			Thread.Sleep(20000);
			Console.WriteLine("Поток в классе А закончил работу");
			mre.Set(); // Передаем сигнал, что можно продажить кто ожитает
		}
	}
	class ClassB
	{
		ManualResetEvent mre;
		public ClassB(ManualResetEvent mre)
		{
			this.mre = mre;
			new Thread(GO).Start();
		}
		private void GO()
		{
			Console.WriteLine("Поток в классе В начал работу");
			Thread.Sleep(15000);
			Console.WriteLine("Поток в классе В закончил работу");
			mre.Set(); // Передаем сигнал, что можно продажить кто ожитает
		}
	}
	
}
