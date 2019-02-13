namespace PatternsGof.AbstractFactory.Abstract
{
	public abstract class Product
	{
		protected IDeveloper developer;
		protected ITester tester;
		protected Ipm pm;
		public void Create()
		{
			pm.Write();
			developer.Write();
			tester.Write();
		}
	}
}
