using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsOOP.Decorator
{
    /*Добавление объекты дополнительной функциональности, состояния и поведения во время выполнения*/

    abstract class Product
    {
        public string Name { get; protected set; }
        public abstract void Operation();
    }
    internal sealed class ProductBottle : Product
    {
        public ProductBottle(string name) { Name = name; }
        public override void Operation()
        {
            Console.WriteLine(Name);
        }
    }
    internal sealed class ProductWater : Product
    {
        Product pr;
        public ProductWater(Product pr)
        {
            this.pr = pr;
        }
        public override void Operation()
        {
            Console.WriteLine("Пьем");
            if (pr != null)
                pr.Operation();
        }
    }
    internal sealed class ProductCap : Product
    {
        Product pr;
        public ProductCap(Product pr)
        {
            this.pr = pr;
        }
        public override void Operation()
        {
            if (pr != null)
            {
                Open();
                pr.Operation();
            }
        }
        private void Open()
        {
            Console.WriteLine("Open cap");
        }
    }

    internal sealed class ClientDecorator
    {
        public void Run()
        {
            Product product = new ProductBottle("Pepsi");
            Product water = new ProductWater(product);
            Product cap = new ProductCap(water);

            cap.Operation();
        }
    }



}
