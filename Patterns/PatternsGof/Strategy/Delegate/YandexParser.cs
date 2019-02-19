using System;

namespace PatternsGof.Strategy.Delegate
{
	public class YandexParser : IParser
	{
		public string Parser(int count)
		{
			Console.WriteLine("Yandex parser");
			return string.Format($"yandex parser: {DateTime.Now}");
		}
	}
}
