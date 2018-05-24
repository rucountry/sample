using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsOOP.AbstractFactory
{
    /*Применяется для пораждения семейств взаимосвязанных продуктов*/

    #region Abstract
    // Абстрактная фабрика, которая порождает продукты одного семейства
    abstract class AbstractFactory
    {
        public abstract AbstractProductWater CreateWater();
        public abstract AbstractProductBottle CreateBottle();
        public abstract AbstractProductCap CreateCap();
        public abstract AbstractProductLabel CreateLabel();
    }
    // Абстрактный класс жидкости
    abstract class AbstractProductWater
    {
        public string Name { get; set; }
        public AbstractProductWater(string name)
        {
            Name = name;
        }
    }
    // Абстрактный класс бутылки
    abstract class AbstractProductBottle
    {
        public string Name { get; set; }
        public AbstractProductBottle(string name)
        {
            Name = name;
        }
		public void Pour(AbstractProductWater aw)
		{
			Console.WriteLine("Наливаем в бутылку жидкость " + aw.Name);
		}
		public void Glue(AbstractProductLabel al)
		{
			Console.WriteLine("Приклеиваем к бутылке этикетку " + al.Name);
		}
		public void Twist(AbstractProductCap ac)
		{
			Console.WriteLine("Закручиваем на бутылке крышку " + ac.Name);
		}
    }
    // Абстрактный класс крышки
    abstract class AbstractProductCap
    {
        public string Name { get; set; }
        public AbstractProductCap(string name)
        {
            Name = name;
        }
    }
    // Абстрактный класс этикетки
    abstract class AbstractProductLabel
    {
        public string Name { get; set; }
        public AbstractProductLabel(string name)
        {
            Name = name;
        }
    }
    #endregion

    #region Concrete Product

    class ConcreteProductWaterPepsi : AbstractProductWater
    {
        public ConcreteProductWaterPepsi() : base("Pepsi") { }
    }
    class ConcreteProductWaterCocaCola : AbstractProductWater
    {
        public ConcreteProductWaterCocaCola() : base("CocaCola") { }
    }
    class ConcreteProductWaterLipton : AbstractProductWater
    {
        public ConcreteProductWaterLipton() : base("Lipton") { }
    }


    class ConcreteProductBottlePepsi : AbstractProductBottle
    {
        public ConcreteProductBottlePepsi() : base("Pepsi") { }
    }
    class ConcreteProductBottleCocaCola : AbstractProductBottle
    {
        public ConcreteProductBottleCocaCola() : base("CocaCola") { }
    }
    class ConcreteProductBottleLipton : AbstractProductBottle
    {
        public ConcreteProductBottleLipton() : base("Lipton") { }
    }


    class ConcreteProductCapPepsi : AbstractProductCap
    {
        public ConcreteProductCapPepsi() : base("Pepsi") { }
    }
    class ConcreteProductCapCocaCola : AbstractProductCap
    {
        public ConcreteProductCapCocaCola() : base("CocaCola") { }
    }
    class ConcreteProductCapLipton : AbstractProductCap
    {
        public ConcreteProductCapLipton() : base("Lipton") { }
    }


    class ConcreteProductLabelPepsi : AbstractProductLabel
    {
        public ConcreteProductLabelPepsi() : base("Pepsi") { }
    }
    class ConcreteProductLabelCocaCola : AbstractProductLabel
    {
        public ConcreteProductLabelCocaCola() : base("CocaCola") { }
    }
    class ConcreteProductLabelLipton : AbstractProductLabel
    {
        public ConcreteProductLabelLipton() : base("Lipton") { }
    }

    #endregion

    #region Concrete Factory

    class ConcreteFactoryPepsi : AbstractFactory
    {
        public override AbstractProductWater CreateWater()
        {
            return new ConcreteProductWaterPepsi();
        }

        public override AbstractProductBottle CreateBottle()
        {
            return new ConcreteProductBottlePepsi();
        }

        public override AbstractProductCap CreateCap()
        {
            return new ConcreteProductCapPepsi();
        }

        public override AbstractProductLabel CreateLabel()
        {
            return new ConcreteProductLabelPepsi();
        }
    }
    class ConcreteFactoryCocaCola : AbstractFactory
    {
        public override AbstractProductWater CreateWater()
        {
            return new ConcreteProductWaterCocaCola();
        }

        public override AbstractProductBottle CreateBottle()
        {
            return new ConcreteProductBottleCocaCola();
        }

        public override AbstractProductCap CreateCap()
        {
            return new ConcreteProductCapCocaCola();
        }

        public override AbstractProductLabel CreateLabel()
        {
            return new ConcreteProductLabelCocaCola();
        }
    }
    class ConcreteFactoryLipton : AbstractFactory
    {
        public override AbstractProductWater CreateWater()
        {
            return new ConcreteProductWaterLipton();
        }

        public override AbstractProductBottle CreateBottle()
        {
            return new ConcreteProductBottleLipton();
        }

        public override AbstractProductCap CreateCap()
        {
            return new ConcreteProductCapLipton();
        }

        public override AbstractProductLabel CreateLabel()
        {
            return new ConcreteProductLabelLipton();
        }
    }


    #endregion

    internal sealed class ClientAbstractFactory
    {
        private AbstractProductWater Water { get; set; }
        private AbstractProductBottle Bottle { get; set; }
        private AbstractProductCap Cap { get; set; }
        private AbstractProductLabel Label { get; set; }

        public void Run()
        {
            AbstractFactory factory = new ConcreteFactoryPepsi();
            
            // Абстрагирование процесса инстанцирования
            Water = factory.CreateWater();
            Bottle = factory.CreateBottle();
            Cap = factory.CreateCap();
            Label = factory.CreateLabel();

            // Абстрагирование вариантов использования
            Bottle.Pour(Water);
            Bottle.Glue(Label);
            Bottle.Twist(Cap);


            factory = new ConcreteFactoryLipton();
            Water = factory.CreateWater();
            Bottle = factory.CreateBottle();
            Cap = factory.CreateCap();
            Label = factory.CreateLabel();

            Bottle.Pour(Water);
            Bottle.Glue(Label);
            Bottle.Twist(Cap);
        }
    }
}
