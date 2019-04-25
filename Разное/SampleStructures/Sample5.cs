using System;
using System.Collections.Generic;
using System.Text;

namespace SampleStructures
{
	class Sample5
	{
		public static void GO()
		{
			Console.WriteLine("Пример 5");
			Console.WriteLine("Использование структур в конструкции using");

			var d = new Disposable();
			using (d)
			{
				// Используем объект d
			}

			// Выведет: Disposed: true? или Disposed: false?
			Console.WriteLine("Disposed: {0}", d.Disposed); // false. Dispose не вызывается
		}
	}

	struct Disposable : IDisposable
	{
		public bool Disposed { get; private set; }
		public void Dispose() { Disposed = true; }
	}
}
