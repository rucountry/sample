namespace PatternsGof.AbstractFactory
{
	public class CSharpProduct : Product
	{
		public CSharpProduct()
		{
			developer = new CSharpDeveloper();
			tester = new CSharpTester();
			pm = new MainPM();
		}
	}
}
