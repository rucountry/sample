namespace PatternsGof.AbstractFactory
{
	public class JavaProduct : Product
	{
		public JavaProduct()
		{
			developer = new JavaDeveloper();
			tester = new JavaTester();
			pm = new SuperMainPM();
		}
	}
}
