using System;
using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;

namespace SampleStructures
{
	class Sample3
	{
		public static void GO()
		{
			Console.WriteLine("Пример 3");
			Console.WriteLine("Mutable structure");
			A a = new A();
			a.Point.Xinc(); // ожидаем 2
			Console.WriteLine($"Свойство Point в классе A { a.Point.X}"); // получаем 1

			B b = new B();
			b.point.Xinc(); // ожидаем 2
			Console.WriteLine($"readonly поле в классе B { b.point.X}"); // получаем 1

			С с = new С();
			с.point.Xinc(); // ожидаем 2
			Console.WriteLine($"поле в классе С (не readonly) { с.point.X}"); // получаем 2
			Console.WriteLine("========================================");
		}
	}

	struct Point3
	{
		public Point3(int x, int y)
		{
			X = x;
			Y = y;
		}
		public int Xinc() => X++;
		public int X { get; private set; }
		public int Y { get; set; }
	}
	class A
	{
		public A()
		{
			Point = new Point3(x: 1, y: 1);
		}
		public Point3 Point { get; private set; }
	}
	class B
	{
		public readonly Point3 point = new Point3(x: 1, y: 1);
	}
	class С
	{
		public Point3 point = new Point3(x: 1, y: 1);
	}
}
