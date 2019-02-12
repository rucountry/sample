namespace PatternsGof.AbstractFactory
{
	public class PhpProduct : Product
	{
		public PhpProduct()
		{
			developer = new PhpDeveloper();
			tester = new PhpTester();
			pm = new SuperMainPM();
		}
	}
}
