using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_5
{
    class Book
    {
        public string[] Name = new string[4];
        public string[,] book = new string[2, 4];
    }
    class BookDemo
    {
        static void Main()
        {
            int i, j;
            Book b = new Book();
            for (i = 0; i < 2; i++)
            {
                Console.WriteLine($"Enter Book {i + 1} details");
                for (j = 0; j < 4; j++)
                {
                    switch (j + 1)
                    {
                        case 1:
                            Console.Write("Book Title:");
                            break;
                        case 2:
                            Console.Write(" Author:");
                            break;
                    }
                    b.Name[j] = Console.ReadLine();
                    b.book[i, j] = b.Name[j];
                }
            }
            Console.Write("\nBookName\tAuthor\n");
            for (i = 0; i < 2; i++)
            {
                for (j = 0; j < 4; j++)
                {
                    Console.Write($"{b.book[i, j]}\t\t");
                }
                Console.Write("\n");
            }
            Console.ReadLine();
        }
    }
}
