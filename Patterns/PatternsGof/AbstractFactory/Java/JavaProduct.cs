using PatternsGof.AbstractFactory.Abstract;

namespace PatternsGof.AbstractFactory.Java
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
