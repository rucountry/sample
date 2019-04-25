using System;
using System.Collections.Generic;
using System.Text;

namespace SampleStructures
{
	class Sample1
	{
		public static void GO()
		{
			Console.WriteLine("Пример 1");
			Console.WriteLine("Конструктор по умолчанию и значение по умолчанию");
			/*конструктор по умолчанию значимого типа*/
			Point i = new Point();
			/*Значение по умолчанию значимого типа*/
			Point ii = default(Point);

			Console.WriteLine($"Конструктор по умолчанию x = {i.x}, y = {i.y}, z is null = {i.z == null}");
			Console.WriteLine($"Инициализация по умолчанию x = {ii.x}, y = {ii.y}, z is null = {ii.z == null}");
			Console.WriteLine("===================================================");
			Console.WriteLine();
		}
	}

	struct Point
	{
		public int x;
		public int y;
		public string z;
	}
}
