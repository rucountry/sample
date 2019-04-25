using System;
using System.Collections.Generic;
using System.Linq;

namespace SampleStructures
{
	class Sample4
	{
		public static void GO()
		{
			Console.WriteLine("Пример 4");
			Console.WriteLine("Массивы и списки в структурах");

			List<Point4> list = new List<Point4> { new Point4(x: 1, y: 1) };
			Point4[] mas = new Point4[] { new Point4(x: 1, y: 1) };
			IList<Point4> list2 = mas.ToList();

			list[0].Xinc(); // ожидаем 2
			mas[0].Xinc(); // ожидаем 2
			list2[0].Xinc(); // ожидаем 2

			Console.WriteLine($"List: {list[0].X}"); // получаем 1
			Console.WriteLine($"Massive: {mas[0].X}"); // получаем 2
			Console.WriteLine($"IList: {list2[0].X}"); // получаем 1

					   
			Console.WriteLine("========================================");

			
		}
	}

	struct Point4
	{
		public Point4(int x, int y)
		{
			X = x;
			Y = y;
		}
		public int Xinc() => X++;
		public int X { get; private set; }
		public int Y { get; set; }
	}
}
