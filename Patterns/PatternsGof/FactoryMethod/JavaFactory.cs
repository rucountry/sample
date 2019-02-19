namespace PatternsGof.FactoryMethod
{
	public class JavaFactory : IFactory
	{
		public IDeveloper CreateDeveloper()
		{
			return new JavaDeveloper();
		}
	}
}
