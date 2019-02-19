namespace PatternsGof.FactoryMethod
{
	public class CSharpFactory : IFactory
	{
		public IDeveloper CreateDeveloper()
		{
			return new CSharpDeveloper();
		}
	}
}
