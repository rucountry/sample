using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace semaphore
{

	class Programm
	{

		static void Main(string[] args)
		{
			// Создаем массив с 30 потоками, которым передаем параметризированный делегат
			var t = new Thread[30];
			for (int i = 0; i < t.Length; i++)
			{
				t[i] = new Thread(new ParameterizedThreadStart(Log.Work));
				t[i].Start(i); // Запускаем каждый поток
			}

			Console.WriteLine("Работа с семафором окончена.");
			Console.ReadLine();
		}
	}
	static class Sem
	{ 
		public static bool onCreated; // хранит значение, запущен ли семафор в другом процессе
		public static Semaphore poll = new Semaphore(5, 5, "testSemaphore", out onCreated);
	}
	class Log
	{

		private static int cur_count;
		Log()
		{
			cur_count = 0;
		}
		public static void Work(object i)
		{
			// Проверяем, запущен ли семафор в другом процессе
			if (Sem.onCreated)
			{
				Sem.poll.WaitOne();
				cur_count++;
				Console.WriteLine("Объект {0} зашел, общее количество = {1}", (int)i, cur_count);
				Thread.Sleep(1000);
				cur_count--;
				Console.WriteLine("Объект {0} покинул, общее количество = {1}", (int)i, cur_count);
				Sem.poll.Release();
			}
			else
				Console.WriteLine("Работа в другом процессе!!!");
		}
	}

}
