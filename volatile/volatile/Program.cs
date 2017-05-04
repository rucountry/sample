using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace @volatile
{

	class Program
	{
		volatile int _firstBool;
		volatile int _secondBool;
		volatile string _firstString;
		volatile string _secondString;

		// Паралельно запускаем 2 метода. Из-за перестановки операций при оптимизации JIT компилятором могут происходить коллизии.
		// Такие баги происходят даже если переменные объявлены, как volatile или используются методы Thread.VolatileRead
		// Чтобы избежать таких коллизий необходимо использовать полную блокировку памяти Thread.MemoryBarrier()

		int _okCount;
		int _failCount;

		static void Main(string[] args)
		{
			new Program().Go();
		}
		private void Go()
		{
			while (true)
			{
				
				Parallel.Invoke(DoThreadA, DoThreadB);
				if (_firstString == null && _secondString == null)
				{
					_failCount++;
				}
				else
				{
					_okCount++;
				}
				Console.WriteLine("ok - {0}, fail - {1}, fail percent - {2}",
							   _okCount, _failCount, GetFailPercent());
				Clear();
			}

		}

		private void DoThreadA()
		{
			_firstBool = 1;
			// Если установить 
			//Thread.MemoryBarrier(); 
			if (Thread.VolatileRead(ref _secondBool) == 1)
			{
				_firstString = "a";
			}
		}

		private void DoThreadB()
		{
			_secondBool = 1;
			//Thread.MemoryBarrier();
			if (Thread.VolatileRead(ref _firstBool) == 1)
			{
				_secondString = "a";
			}
		}
		private void Clear()
		{
			_firstBool = 0;
			_secondBool = 0;
			_firstString = null;
			_secondString = null;
		}
		private float GetFailPercent()
		{
			return (float)_failCount / (_okCount + _failCount) * 100;
		}
	}

}
