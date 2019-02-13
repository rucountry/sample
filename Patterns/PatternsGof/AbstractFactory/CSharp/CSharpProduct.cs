using PatternsGof.AbstractFactory.Abstract;


namespace PatternsGof.AbstractFactory.CSharp
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
