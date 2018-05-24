using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsOOP._1_Порождающие.Singleton
{
	class Singleton2
	{
		private Singleton2() { }
		public static Singleton2 GetInstance()
		{
			return SingNested._objsingleton;
		}

		internal class SingNested
		{
			internal static readonly Singleton2 _objsingleton = new Singleton2();
		}
	}
}
