using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace mutex
{

	class Program
	{
		static void Main(string[] args)
		{
			// Создаем массив потоков, которые ниже запускаем с блокировкой главного потока 
			var t = new Thread[2] { new Thread(Plus.Run), new Thread(Minus.Run) };
			foreach (var item in t)
			{
				item.Start();
				item.Join(); // блокировка главного потока
			}
			Console.ReadLine();
		}

	}
	class MutexShared
	{
		public static bool oncreated;
		public static readonly Mutex mut = new Mutex(false, "newmutext", out oncreated);
		public static int res;
	}
	class Plus
	{
		public static void Run()
		{
			// Проверяем запущен ли мутекх в другом процессе. Межпроцессорное взаимодействие
			if (MutexShared.oncreated)
			{
				MutexShared.mut.WaitOne();

				for (int i = 0; i < 3; i++)
				{
					MutexShared.res++;
					Console.WriteLine(MutexShared.res);
					Thread.Sleep(1000);
				}

				MutexShared.mut.ReleaseMutex();
			}
			else Console.WriteLine("Метод выполняется в другом процессе");
		}
	}
	class Minus
	{
		public static void Run()
		{
			// Проверяем запущен ли мутекх в другом процессе. Межпроцессорное взаимодействие
			if (MutexShared.oncreated)
			{
				MutexShared.mut.WaitOne();

				for (int i = 0; i < 3; i++)
				{
					MutexShared.res--;
					Console.WriteLine(MutexShared.res);
					Thread.Sleep(1000);
				}

				MutexShared.mut.ReleaseMutex();
			}
			else Console.WriteLine("Метод выполняется в другом процессе");
		}
	}

}
