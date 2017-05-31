using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsOOP.Builder
{
    /*Применяется для пошагового конструирования сложных продуктов*/

    #region Абстракция продукта
    interface IName
    {
        string Name { get; set; }
    }

    // Абстракция бутылки
    abstract class ProductBottle : IName
    {
        public string Name { get; set; }
        public ProductBottle(string name)
        {
            this.Name = name;
        }
    }
    // Абстракция жидкости
    abstract class ProductWater : IName
    {
        public string Name { get; set; }
        public ProductWater(string name)
        {
            this.Name = name;
        }
    }
    // Абстракция крышки
    abstract class ProductCap : IName
    {
        public string Name { get; set; }
        public ProductCap(string name)
        {
            this.Name = name;
        }
    }
    // Абстракция этикетки
    abstract class ProductLabel : IName
    {
        public string Name { get; set; }
        public ProductLabel(string name)
        {
            this.Name = name;
        }
    }

    
    // Абстрактный продукт
    abstract class Product
    {
        ArrayList list = new ArrayList();
        // Добавление компонента продукта
        public void Add(IName obj)
        {
            list.Add(obj);
        }
        // Из каких компонентов состоит продукт
        public void Show()
        {
            foreach (var item in list)
            {
                Console.WriteLine(((IName)item).Name);
            }
        }
    }


    #endregion

    #region Реализация продукта

    class ProductBottlePepsi : ProductBottle
    {
        public ProductBottlePepsi() : base("BottlePepsi") {  }
    }
    class ProductBottleCocaCola : ProductBottle
    {
        public ProductBottleCocaCola() : base("BottleCocaCola") { }
    }
    class ProductBottleLipton : ProductBottle
    {
        public ProductBottleLipton() : base("BottleLipton") { }
    }


    class ProductWaterPepsi : ProductWater
    {
        public ProductWaterPepsi() : base("WaterPepsi") { }
    }
    class ProductWaterCocaCola : ProductWater
    {
        public ProductWaterCocaCola() : base("WaterCocaCola") { }
    }
    class ProductWaterLipton : ProductWater
    {
        public ProductWaterLipton() : base("WaterLipton") { }
    }


    class ProductCapPepsi : ProductCap
    {
        public ProductCapPepsi() : base("CapPepsi") { }
    }
    class ProductCapCocaCola : ProductCap
    {
        public ProductCapCocaCola() : base("CapCocaCola") { }
    }
    class ProductCapLipton : ProductCap
    {
        public ProductCapLipton() : base("CapLipton") { }
    }


    class ProductLabelPepsi : ProductLabel
    {
        public ProductLabelPepsi() : base("LabelPepsi") { }
    }
    class ProductLabelCocaCola : ProductLabel
    {
        public ProductLabelCocaCola() : base("LabelCocaCola") { }
    }
    class ProductLabelLipton : ProductLabel
    {
        public ProductLabelLipton() : base("LabelLipton") { }
    }

    class ProductPepsi : Product 
    {
    }
    class ProductLipton : Product 
    {
    }
    class ProductCocaCola : Product 
    {
    }


    #endregion

    #region Абстракция строителя

    abstract class Builder
    {
        protected Product product;
        public abstract void CreateBottle();
        public abstract void CreateWater();
        public abstract void CreateCap();
        public abstract void CreateLabel();
        public Product CreateProduct()
        {
            return product;
        }

    }

    #endregion

    #region Конкретные реализации строителей
    
    class BuilderPepsi : Builder
    {
        public BuilderPepsi()
        {
            product = new ProductPepsi();
        }
        public sealed override void CreateBottle()
        {
            product.Add(new ProductBottlePepsi());
        }
        public sealed override void CreateWater()
        {
            product.Add(new ProductWaterPepsi());
        }
        public sealed override void CreateCap()
        {
            product.Add(new ProductCapPepsi());
        }
        public sealed override void CreateLabel()
        {
            product.Add(new ProductLabelPepsi());
        }
    }
    class BuilderCocaCola : Builder
    {
        public BuilderCocaCola()
        {
            product = new ProductCocaCola();
        }
        public sealed override void CreateBottle()
        {
            product.Add(new ProductBottleCocaCola());
        }
        public sealed override void CreateWater()
        {
            product.Add(new ProductWaterCocaCola());
        }
        public sealed override void CreateCap()
        {
            product.Add(new ProductCapCocaCola());
        }
        public sealed override void CreateLabel()
        {
            product.Add(new ProductLabelCocaCola());
        }
    }
    class BuilderLipton : Builder
    {
        public BuilderLipton()
        {
            product = new ProductLipton();
        }
        public sealed override void CreateBottle()
        {
            product.Add(new ProductBottleLipton());
        }
        public sealed override void CreateWater()
        {
            product.Add(new ProductWaterLipton());
        }
        public sealed override void CreateCap()
        {
            product.Add(new ProductCapLipton());
        }
        public sealed override void CreateLabel()
        {
            product.Add(new ProductLabelLipton());
        }
     }
    
    #endregion

    class Director
    {
        Builder builder;
        public Director(Builder builder)
        {
            this.builder = builder;
        }
        public void ConstructProduct()
        {
            builder.CreateLabel();
            builder.CreateBottle();
            builder.CreateCap();
            builder.CreateWater();
        }

    }
   
    internal sealed class ClientBuilder
    {
        public void Run()
        {
            Product product;
            BuilderLipton bl = new BuilderLipton();
            Director director = new Director(bl);
            director.ConstructProduct();
            product = bl.CreateProduct();
            product.Show();
        }
    }


}
