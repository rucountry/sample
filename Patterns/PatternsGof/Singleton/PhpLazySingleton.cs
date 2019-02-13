namespace PatternsGof.Singleton
{
	// Lazy реализация синглетона
	public class PhpLazySingleton
	{
		public static string DateTime { get; set; }
		private PhpLazySingleton()
		{
			DateTime = System.DateTime.Now.ToString();
			System.Console.WriteLine("ctor");
		}

		public static PhpLazySingleton Get()
		{
			System.Console.WriteLine("Get");
			return Nested.phpLazySingleton;
		}

		private static class Nested
		{
			internal static readonly PhpLazySingleton phpLazySingleton = new PhpLazySingleton();
			static Nested() { System.Console.WriteLine("Nested"); }
		}
	}
}
