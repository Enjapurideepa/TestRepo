using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public class Shape
    {
        public virtual void WhoAmI()
        {
            Console.WriteLine("I am Shape");
        }
    }

    public class Triangle : Shape
    {
        public override void WhoAmI()
        {
            Console.WriteLine("I am Triangle");
        }
    }
    public class Circle : Shape
    {
        public override void WhoAmI()
        {
            Console.WriteLine("I am Circle");
        }
    }
    class Lab4q2
    {

        static void Main(string[] args)
        {
            Shape shape;
            shape = new Triangle();
            shape.WhoAmI();
            shape = new Circle();
            shape.WhoAmI();
            Console.ReadKey();
        }

    }
}

