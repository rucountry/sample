using System;

namespace PatternsGof.Strategy.Delegate
{
	public class GoogleParser : IParser
	{
		public string Parser(int count)
		{
			Console.WriteLine("Google parser");
			return string.Format($"google parser: {DateTime.Now}");
		}
	}
}
