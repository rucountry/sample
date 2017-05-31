using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsOOP.Interpreter
{
    /*Объекто-ориентированное представление грамматики*/

    /*Реализуем грамматику такого выражение x+y-z*/

    class Context
    {
        public Dictionary<string, int> list = new Dictionary<string, int>();

        public int GetValueByName(string name)
        {
            return list[name];
        }
        public void Add(string name, int value)
        {
            list.Add(name, value);
        }
    }

    abstract class Expr
    {
        public abstract int Interpret(Context cnt);
    }

    // терминальное выражение
    class NumberExpr : Expr
    {
        string name;
        public NumberExpr(string name)
        {
            this.name = name;
        }
        public override int Interpret(Context cnt)
        {
           return cnt.GetValueByName(name);
        }
    }
    // нетерминальное выражение
    class PlusEspr : Expr
    {
        public Expr leftExpr;
        public Expr rightExpr;

        public PlusEspr(Expr left, Expr right)
        {
            this.leftExpr = left;
            this.rightExpr = right;
        }

        public override int Interpret(Context cnt)
        {
            return leftExpr.Interpret(cnt) + rightExpr.Interpret(cnt);
        }
    }
    class MinusEspr : Expr
    {
        public Expr leftExpr;
        public Expr rightExpr;

        public MinusEspr(Expr left, Expr right)
        {
            this.leftExpr = left;
            this.rightExpr = right;
        }

        public override int Interpret(Context cnt)
        {
            return leftExpr.Interpret(cnt) - rightExpr.Interpret(cnt);
        }
    }

    class ClientInterpreter
    {
        public void Run()
        {
            int x = 10;
            int y = 20;
            int z = 5;
            Context cnt = new Context();
            cnt.Add("x",x);
            cnt.Add("y",y);
            cnt.Add("z",z);
            Expr exp = new MinusEspr(new PlusEspr(new NumberExpr("x"), new NumberExpr("y")), new NumberExpr("z"));
            Console.WriteLine("Вычислим выражение x+y-z");
            Console.WriteLine(exp.Interpret(cnt).ToString());

        }
    }
}
