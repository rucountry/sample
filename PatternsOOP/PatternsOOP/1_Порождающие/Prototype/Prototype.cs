using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsOOP.Prototype
{
    /*Клонирование объекта*/
   abstract class ProductPrototype
    {
        protected string Bottle { get; private set; }
        protected string Cap { get; private set; }
        protected string Label { get; private set; }
        protected string Water { get; private set; }

        public ProductPrototype(string bottle, string cap, string label, string water)
        {
            Bottle = bottle;
            Cap = cap;
            Label = label;
            Water = water;
        }
        public void Show()
        {
            Console.WriteLine("{0}-{1}-{2}-{3}", Bottle, Cap, Label, Water);
        }

        public abstract ProductPrototype Clone();
        
    }
    class ProductPepsi : ProductPrototype
    {
        public ProductPepsi() : base("bottlePepsi", "capPepsi", "labelPepsi", "waterPepsi") { }

        public override ProductPrototype Clone()
        {
            return new ProductPepsi();
        }
    }
    class ProductCocaCola : ProductPrototype
    {
        public ProductCocaCola() : base("bottleCocaCola", "capCocaCola", "labelCocaCola", "waterCocaCola") { }

        public override ProductPrototype Clone()
        {
            return new ProductCocaCola();
        }
    }
    class ProductLipton : ProductPrototype
    {
        public ProductLipton() : base("bottleLipton", "capLipton", "labelLipton", "waterLipton") { }

        public override ProductPrototype Clone()
        {
            return new ProductLipton();
        }
    }

    internal sealed class ClientPrototype
    {
        public void Run()
        {
            ProductPrototype origin;
            ProductPrototype cocacola;
            origin = new ProductCocaCola();
            cocacola = origin.Clone();
            cocacola.Show();
        }
    }
}
