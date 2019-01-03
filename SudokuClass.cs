using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication18
{
    class SudokuClass
    {
        int[,] matris;
        int[,] matris2;
        int[,] matris3;

        public SudokuClass(int [,]x)
        {
            matris = x;
            matris2 = x;
            matris3 = x;           
        }

        public void Oyna()
        {
            ConsoleKeyInfo tuş1;
            int x = 1;
            int y = 1;

            x = Console.CursorLeft;
            y = Console.CursorTop;
            ekranaYaz(matris);
            do
            {
                 tuş1 = Console.ReadKey();
                if (tuş1.Key == ConsoleKey.DownArrow)
                    y += 1;
                if (tuş1.Key == ConsoleKey.UpArrow && y>0)
                    y -= 1;
                if (tuş1.Key == ConsoleKey.RightArrow)
                    x += 2;
                if (tuş1.Key == ConsoleKey.LeftArrow && x>2)
                    x -= 2;

                ekranaYaz(matris);
                Console.SetCursorPosition(x, y);

            } while (tuş1.Key != ConsoleKey.Escape);
        }

        void ekranaYaz(int[,] dizi)
        {
            Console.Clear();
            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    Console.Write("{0} ", dizi[i, j]);
                }
                Console.WriteLine();
            }
        }
        public void map2Goster()
        {
            ConsoleKeyInfo tuş1;
            int x = 1;
            int y = 1;

            x = Console.CursorLeft;
            y = Console.CursorTop;
            ekranaYaz(matris2);
            do
            {
                tuş1 = Console.ReadKey();
                if (tuş1.Key == ConsoleKey.DownArrow)
                    y += 1;
                if (tuş1.Key == ConsoleKey.UpArrow && y > 0)
                    y -= 1;
                if (tuş1.Key == ConsoleKey.RightArrow)
                    x += 2;
                if (tuş1.Key == ConsoleKey.LeftArrow && x > 2)
                    x -= 2;

                ekranaYaz(matris2);
                Console.SetCursorPosition(x, y);

            } while (tuş1.Key != ConsoleKey.Escape);
        }
        public void map3Goster()
        {
            ConsoleKeyInfo tuş1;
            int x = 1;
            int y = 1;

            x = Console.CursorLeft;
            y = Console.CursorTop;
            ekranaYaz(matris3);
            do
            {
                tuş1 = Console.ReadKey();
                if (tuş1.Key == ConsoleKey.DownArrow)
                    y += 1;
                if (tuş1.Key == ConsoleKey.UpArrow && y > 0)
                    y -= 1;
                if (tuş1.Key == ConsoleKey.RightArrow)
                    x += 2;
                if (tuş1.Key == ConsoleKey.LeftArrow && x > 2)
                    x -= 2;

                ekranaYaz(matris3);
                Console.SetCursorPosition(x, y);

            } while (tuş1.Key != ConsoleKey.Escape);
        }
           
            
    }
}
