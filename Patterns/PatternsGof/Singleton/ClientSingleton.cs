using System;

namespace PatternsGof.Singleton
{
	class ClientSingleton
	{
		public void Go()
		{
			JavaDeveloper javaDeveloper = JavaDeveloper.Get();
			javaDeveloper.Name = "SRF";
			Console.WriteLine(javaDeveloper.Name);
			Console.WriteLine("=================");
			JavaDeveloper javaDeveloper2 = JavaDeveloper.Get();
			Console.WriteLine(javaDeveloper2.Name);
			Console.WriteLine("=================");

			CSharpDeveloper cSharpDeveloper = CSharpDeveloper.Get();
			Console.WriteLine(cSharpDeveloper.Name);
			Console.WriteLine(CSharpDeveloper.Get().Name);

			PhpLazySingleton php = PhpLazySingleton.Get();

		}
	}
}
