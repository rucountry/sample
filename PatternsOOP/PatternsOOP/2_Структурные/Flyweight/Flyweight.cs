using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsOOP.Flyweight
{
    /*Организует работу с разделяемыми ресурсами. Разделяемые ресурсы хранят общее внутреннее состояние всех приспособленцев. 
     * Внешнее хранится в неразделяемых объектах и уникально для каждого*/

    interface IFlyweight
    {
        void Operation();
    }

    class SharedComponent : IFlyweight
    {
        private int i = 0;
        public SharedComponent(int i)
        {
            this.i = i;
        }
        public void Operation()
        {
            Console.WriteLine("Разделяемый ресурс " + this.i);
        }
    }
    class UnSharedComponent : IFlyweight
    {
        SharedComponent sc;
        int j = 0;

        public UnSharedComponent(SharedComponent sc)
        {
            this.sc = sc;
        }

        public void Operation()
        {
            sc.Operation();    
        }
    }

    // Фабрика создания разделяемого ресурса
    class FactoryFlyweight
    {
        private Hashtable pool = new Hashtable();
        public SharedComponent Get(int key)
        {
            if (!pool.Contains(key))
                pool.Add(key, new SharedComponent(key));

            return pool[key] as SharedComponent;
        }
    }

    class ClientFlyweight
    {
        IFlyweight flyweight;
        FactoryFlyweight factory = new FactoryFlyweight();
        public void Run()
        {
            flyweight = new UnSharedComponent(factory.Get(1));
            flyweight.Operation();
            
            flyweight = new UnSharedComponent(factory.Get(1));
            flyweight.Operation();
            
            flyweight = new UnSharedComponent(factory.Get(2));
            flyweight.Operation();
        }
    }
}
