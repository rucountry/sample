namespace PatternsGof.TemplateMethod
{
	public class JavaFactory : IFactory
	{
		public IDeveloper CreateDeveloper()
		{
			return new JavaDeveloper();
		}
	}
}
