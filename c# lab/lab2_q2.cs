using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_q2
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[,] Data = new int[5, 6];
            for (int i = 0; i <= Data.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= Data.GetUpperBound(1); j++)
                {
                    Console.Write("Enter value for[{0}][{1}] : ", i, j);
                    Data[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Printing The Array:-");
            for (int i = 0; i <= Data.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= Data.GetUpperBound(1); j++)
                {
                    Console.Write(Data[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
                   




