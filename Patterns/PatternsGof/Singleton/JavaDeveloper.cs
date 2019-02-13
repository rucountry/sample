namespace PatternsGof.Singleton
{
	// Потокобезопасный синглетон
	public class JavaDeveloper
	{
		private static JavaDeveloper java = null;
		private static object obj = new object();
		
		public string Name { get; set; }

		private JavaDeveloper()
		{
		}

		public static JavaDeveloper Get()
		{
			if (java == null)
			{
				lock (obj)
				{
					if (java == null)
						java = new JavaDeveloper();
				}
			}

			return java;
		}
		
	}
}
