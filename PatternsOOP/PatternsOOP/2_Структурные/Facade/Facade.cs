using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsOOP.Facade
{
    /*Сокрытие сложных связей отношений между объектами в специальный объект*/
    internal sealed class FactoryFacade
    {
        ProductBootle pb = new ProductBootle();
        ProductLabel pl = new ProductLabel();
        ProductCap pc = new ProductCap();
        ProductWater pw = new ProductWater();

        public void RunProcess()
        {
            pb.CreateBootle();
            pb.Operation();
            pw.CreateWater();
            pw.Operation();
            pw.Add();
            pc.CreateCap();
            pc.Operation();
            pc.Add();
            pl.CreateLabel();
            pl.Operation();
            pl.Add();
            Console.WriteLine("Бутылка готова!!!");
        }
    }
    internal sealed class ProductBootle
    {
        public void CreateBootle() { Console.WriteLine("Создать бутылку"); }
        public void Operation() { Console.WriteLine("Отправить в отдел качества"); }
    }
    internal sealed class ProductLabel
    {
        public void CreateLabel() { Console.WriteLine("Изготовить этикетку"); }
        public void Operation() { Console.WriteLine("Отправить в отдел качества этикетку"); }
        public void Add() { Console.WriteLine("Прикрепить этикетку к бутылке"); }
    }
    internal sealed class ProductCap
    {
        public void CreateCap() { Console.WriteLine("Изготовить крышку"); }
        public void Operation() { Console.WriteLine("Отправить крышку в отдел качества"); }
        public void Add() { Console.WriteLine("Прикрепить крышку к бутылке"); }
    }
    internal sealed class ProductWater
    {
        public void CreateWater() { Console.WriteLine("Произвести жидеости Pepsi"); }
        public void Operation() { Console.WriteLine("Отправить жидкость в отдел качества"); }
        public void Add() { Console.WriteLine("Залить жидкость к бутылке"); }
    }

    internal sealed class ClientFacade
    {
        public void Run()
        {
            FactoryFacade ff = new FactoryFacade();
            ff.RunProcess();
        }
    }

}
