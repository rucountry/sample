namespace PatternsGof.TemplateMethod
{
	public class CSharpFactory : IFactory
	{
		public IDeveloper CreateDeveloper()
		{
			return new CSharpDeveloper();
		}
	}
}
