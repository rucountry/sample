using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsOOP.FactoryMethod
{
    /*Абстрагирование процесса инстанцирования. Основа для других пораждающих паттернов*/

    #region Абстракция
    abstract class Product { }
    
    abstract class Factory
    {
        public abstract Product Create(); // Фабричный метод
    }
    #endregion

    #region Конкретика
    class ProductCocaCola : Product
    {
 
    }
    class ProductPepsi : Product
    {
 
    }
    class ProductLipton : Product
    {
 
    }

    class FactoryCocaCola : Factory
    {
        public override Product Create()
        {
            Console.WriteLine("CocaCola");
            return new ProductCocaCola();
        }
    }
    class FactoryPepsi : Factory
    {
        public override Product Create()
        {
            Console.WriteLine("Pepsi");
            return new ProductPepsi();
        }
    }
    class FactoryLipton : Factory
    {
        public override Product Create()
        {
            Console.WriteLine("Lipton");
            return new ProductLipton();
        }
    }
    #endregion

    internal sealed class ClientFactoryMethod
    {
        public void Run()
        {
            Factory factory = new FactoryCocaCola();
            Product product = factory.Create();
            Console.WriteLine("-------------");
            factory = new FactoryPepsi();
            product = factory.Create();
        }
    }
}
