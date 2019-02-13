namespace PatternsGof.Singleton
{
	// Потокобезопасная реализация синглетона без использования lock
	public class CSharpDeveloper
	{
		private static readonly CSharpDeveloper cSharp = new CSharpDeveloper();
		public string Name { get; }

		private CSharpDeveloper()
		{
			Name = "SRF";
		}

		public static CSharpDeveloper Get()
		{
			return cSharp;
		}
	}
}
