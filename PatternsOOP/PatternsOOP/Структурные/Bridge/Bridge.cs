using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsOOP.Bridge
{
    /*Отделение реализации от абстракции.*/

    
    public class ProductBootle
    {
        public string Name { get; set; }
        public ProductBootle(string name) { Name = name; }
    }
    class ProductLabel
    {
        public string Name { get; set; }
        public ProductLabel(string name) { Name = name; }
    }
    class ProductCap
    {
        public string Name { get; set; }
        public ProductCap(string name) { Name = name; }
    }
    class ProductWater
    {
        public string Name { get; set; }
        public ProductWater(string name) { Name = name; }
    }

    #region Abstraction Bootle
    abstract class AbstractProductBootle
    {
        public abstract void Operation();
    }
    internal sealed class ProductBootlePepsi : AbstractProductBootle
    {
        ProductBootle pb;
        public ProductBootlePepsi(ProductBootle pb)
        {
            this.pb = pb;
        }

        public override void Operation()
        {
            Console.WriteLine(pb.Name);
        }
    }
    internal sealed class ProductBootleCocaCole : AbstractProductBootle
    {
        ProductBootle pb;
        public ProductBootleCocaCole(ProductBootle pb)
        {
            this.pb = pb;
        }

        public override void Operation()
        {
            Console.WriteLine(pb.Name);
        }
    }
    internal sealed class ProductBootleLipton : AbstractProductBootle
    {
        ProductBootle pb;
        public ProductBootleLipton(ProductBootle pb)
        {
            this.pb = pb;
        }

        public override void Operation()
        {
            Console.WriteLine(pb.Name);
        }
    }
    #endregion
    #region Abstraction Label
    abstract class AbstractProductLabel
    {
        public abstract void Operation();
    }
    internal sealed class ProductLabelPepsi : AbstractProductLabel
    {
        ProductLabel pb;
        public ProductLabelPepsi(ProductLabel pb)
        {
            this.pb = pb;
        }

        public override void Operation()
        {
            Console.WriteLine(pb.Name);
        }
    }
    internal sealed class ProductLabelCocaCole : AbstractProductLabel
    {
        ProductLabel pb;
        public ProductLabelCocaCole(ProductLabel pb)
        {
            this.pb = pb;
        }

        public override void Operation()
        {
            Console.WriteLine(pb.Name);
        }
    }
    internal sealed class ProductLabelLipton : AbstractProductLabel
    {
        ProductLabel pb;
        public ProductLabelLipton(ProductLabel pb)
        {
            this.pb = pb;
        }

        public override void Operation()
        {
            Console.WriteLine(pb.Name);
        }
    }
    #endregion
    #region Abstraction Cap
    abstract class AbstractProductCap
    {
        public abstract void Operation();
    }
    internal sealed class ProductCapPepsi : AbstractProductCap
    {
        ProductCap pb;
        public ProductCapPepsi(ProductCap pb)
        {
            this.pb = pb;
        }

        public override void Operation()
        {
            Console.WriteLine(pb.Name);
        }
    }
    internal sealed class ProductCapCocaCole : AbstractProductCap
    {
        ProductCap pb;
        public ProductCapCocaCole(ProductCap pb)
        {
            this.pb = pb;
        }

        public override void Operation()
        {
            Console.WriteLine(pb.Name);
        }
    }
    internal sealed class ProductCapLipton : AbstractProductCap
    {
        ProductCap pb;
        public ProductCapLipton(ProductCap pb)
        {
            this.pb = pb;
        }

        public override void Operation()
        {
            Console.WriteLine(pb.Name);
        }
    }
    #endregion
    #region Abstraction Water
    abstract class AbstractProductWater
    {
        public abstract void Operation();
    }
    internal sealed class ProductWaterPepsi : AbstractProductWater
    {
        ProductWater pb;
        public ProductWaterPepsi(ProductWater pb)
        {
            this.pb = pb;
        }

        public override void Operation()
        {
            Console.WriteLine(pb.Name);
        }
    }
    internal sealed class ProductWaterCocaCole : AbstractProductWater
    {
        ProductWater pb;
        public ProductWaterCocaCole(ProductWater pb)
        {
            this.pb = pb;
        }

        public override void Operation()
        {
            Console.WriteLine(pb.Name);
        }
    }
    internal sealed class ProductWaterLipton : AbstractProductWater
    {
        ProductWater pb;
        public ProductWaterLipton(ProductWater pb)
        {
            this.pb = pb;
        }

        public override void Operation()
        {
            Console.WriteLine(pb.Name);
        }
    }
    #endregion




    #region Implementation
    abstract class ImpProductBottle
    {
        public abstract ProductBootle CreateBottle();
    }
    internal sealed class ImpProductBottlePepsi : ImpProductBottle
    {
        public override ProductBootle CreateBottle()
        {
            return new ProductBootle("CreateBottle Pepsi");
        }
    }
    internal sealed class ImpProductBootleCocaCola : ImpProductBottle
    {
        public override ProductBootle CreateBottle()
        {
            return new ProductBootle("CreateBottle CocaCola");
        }
    }
    internal sealed class ImpProductBootleLipton : ImpProductBottle
    {
        public override ProductBootle CreateBottle()
        {
            return new ProductBootle("CreateBottle Lipton");
        }
    }
    #endregion
    #region Implementation
    abstract class ImpProductLabel
    {
        public abstract ProductLabel CreateLabel();
    }
    internal sealed class ImpProductLabelPepsi : ImpProductLabel
    {
        public override ProductLabel CreateLabel()
        {
            return new ProductLabel("CreateLabel Pepsi");
        }
    }
    internal sealed class ImpProductLabelCocaCola : ImpProductLabel
    {
        public override ProductLabel CreateLabel()
        {
            return new ProductLabel("CreateLabel CocaCola");
        }
    }
    internal sealed class ImpProductLabelLipton : ImpProductLabel
    {
        public override ProductLabel CreateLabel()
        {
            return new ProductLabel("CreateLabel Lipton");
        }
    }
    #endregion
    #region Implementation
    abstract class ImpProductCap
    {
        public abstract ProductCap CreateCap();
    }
    internal sealed class ImpProductCapPepsi : ImpProductCap
    {
        public override ProductCap CreateCap()
        {
            return new ProductCap("CreateCap Pepsi");
        }
    }
    internal sealed class ImpProductCapCocaCola : ImpProductCap
    {
        public override ProductCap CreateCap()
        {
            return new ProductCap("CreateCap CocaCola");
        }
    }
    internal sealed class ImpProductCapLipton : ImpProductCap
    {
        public override ProductCap CreateCap()
        {
            return new ProductCap("CreateCap Lipton");
        }
    }
    #endregion
    #region Implementation
    abstract class ImpProductWater
    {
        public abstract ProductWater CreateWater();
    }
    internal sealed class ImpProductWaterPepsi : ImpProductWater
    {
        public override ProductWater CreateWater()
        {
            return new ProductWater("CreateWater Pepsi");
        }
    }
    internal sealed class ImpProductWaterCocaCola : ImpProductWater
    {
        public override ProductWater CreateWater()
        {
            return new ProductWater("CreateWater CocaCola");
        }
    }
    internal sealed class ImpProductWaterLipton : ImpProductWater
    {
        public override ProductWater CreateWater()
        {
            return new ProductWater("CreateWater Lipton");
        }
    }
    #endregion

    internal sealed class ClientBridge
    {
        public void Run()
        {
            ProductBootlePepsi pb = new ProductBootlePepsi(new ImpProductBottlePepsi().CreateBottle());
            ProductLabelPepsi pl = new ProductLabelPepsi(new ImpProductLabelPepsi().CreateLabel());
            ProductCapPepsi pc = new ProductCapPepsi(new ImpProductCapPepsi().CreateCap());
            ProductWaterPepsi pw = new ProductWaterPepsi(new ImpProductWaterPepsi().CreateWater());
            pb.Operation();
            pl.Operation();
            pc.Operation();
            pw.Operation();
        }
    }
}
