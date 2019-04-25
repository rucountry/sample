using System;
using System.Collections.Generic;
using System.Text;

namespace SampleStructures
{
	class Sample2
	{
		public static void GO()
		{
			Console.WriteLine("Пример 2");
			Console.WriteLine("Вызываем конструктор по умолчанию через this(), предотвращая передачу всех параметров для структуры");
			Point2 point1 = new Point2();
			Point2 point2 = new Point2(2);
			Console.WriteLine($"point1 x = {point1.x}, y = {point1.y}, z is null = {point1.z == null}");
			Console.WriteLine($"point2 x = {point2.x}, y = {point2.y}, z is null = {point2.z == null}");
			Console.WriteLine("===================================================");
			Console.WriteLine();
		}
	}

	struct Point2
	{
		public Point2(int x) : this()
		{
			this.x = x;
		}
		public int x;
		public int y;
		public string z;
	}
}
