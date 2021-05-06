using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class SquareAndCube
    {
        struct Number
        {
            public int side;
            public int square()
            {
                return side * side;
            }
            public int cube()
            {
                return side * side * side;
            }
        }
        static void Main(string[] args)
        {
            Number n;
            int choice;
            bool loop = true;
            while (loop)
            {
                Console.WriteLine("Menu");
                Console.Write("1.Square\n2.Cube\n3.Exit\nEnter choice:");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.Write("Enter a number: ");
                        n.side = int.Parse(Console.ReadLine());
                        Console.WriteLine("Square = " + n.square());
                        break;
                    case 2:
                        Console.Write("Enter a number: ");
                        n.side = int.Parse(Console.ReadLine());
                        Console.WriteLine("Cube = " + n.cube());
                        break;
                    case 3:
                        loop = false;
                        break;
                }
            }
            Console.WriteLine("End of programe");
            Console.ReadKey();
        }
    }
}
