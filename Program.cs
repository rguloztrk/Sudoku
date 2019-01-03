using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication18
{
    class Program
    {
        static int[,] map1(int [,]map)
        {

            map[1, 6] = 3;
            map[1, 7] = 8;
            map[1, 8] = 7;
            map[2, 1] = 7;
            map[2, 2] = 2;
            map[2, 3] = 6;
            map[2, 4] = 4;
            map[2, 8] = 9;
            map[3, 1] = 1;
            map[3, 4] = 7;
            map[3, 6] = 2;
            map[3, 8] = 5;
            map[4, 1] = 4;
            map[4, 3] = 5;
            map[4, 7] = 6;
            map[4, 8] = 3;
            map[5, 1] = 2;
            map[5, 5] = 5;
            map[5, 9] = 8;
            map[6, 2] = 1;
            map[6, 3] = 8;
            map[6, 7] = 2;
            map[6, 9] = 5;
            map[7, 2] = 5;
            map[7, 4] = 2;
            map[7, 6] = 6;
            map[7, 9] = 4;
            map[8, 2] = 3;
            map[8, 6] = 7;
            map[8, 7] = 9;
            map[8, 8] = 6;
            map[8, 9] = 1;
            map[9, 2] = 4;
            map[9, 3] = 1;
            map[9, 4] = 9;
            map[9, 5] = 3;

            return map;
        }

        static int[,] map2(int[,] map)
        {
            map[1, 1] = 2;
            map[1, 2] = 8;
            map[1, 4] = 7;
            map[1, 5] = 1;
            map[1, 7] = 9;
            map[1, 9] = 4;
            map[2, 1] = 6;
            map[2, 2] = 9;
            map[2, 6] = 2;
            map[2, 9] = 3;
            map[3, 3] = 1;
            map[3, 6] = 4;
            map[3, 8] = 2;
            map[4, 1] = 5;
            map[4, 2] = 4;
            map[4, 5] = 7;
            map[4, 7] = 3;
            map[4, 8] = 8;
            map[6, 2] = 6;
            map[6, 3] = 2;
            map[6, 5] = 4;
            map[6, 8] = 5;
            map[6, 9] = 7;
            map[7, 2] = 5;
            map[7, 4] = 9;
            map[7, 7] = 2;
            map[8, 1] = 9;
            map[8, 4] = 2;
            map[8, 8] = 7;
            map[8, 9] = 5;
            map[9, 1] = 3;
            map[9, 3] = 7;
            map[9, 5] = 5;
            map[9, 6] = 1;
            map[9, 8] = 9;
            map[9, 9] = 6;

            return map;
        }

        static int[,] map3(int[,] map)
        {
            map[1, 3] = 6;
            map[1, 5] = 8;
            map[1, 6] = 3;
            map[1, 8] = 1;
            map[2, 3] = 5;
            map[2, 5] = 6;
            map[2, 6] = 4;
            map[2, 8] = 3;
            map[3, 1] = 9;
            map[3, 5] = 7;
            map[3, 9] = 5;
            map[4, 3] = 8;
            map[4, 8] = 9;
            map[5, 3] = 1;
            map[5, 7] = 4;
            map[6, 2] = 2;
            map[6, 7] = 1;
            map[7, 1] = 7;
            map[7, 5] = 2;
            map[7, 9] = 1;
            map[8, 2] = 3;
            map[8, 4] = 6;
            map[8, 5] = 4;
            map[8, 7] = 7;
            map[9, 2] = 6;
            map[9, 4] = 3;
            map[9, 5] = 1;
            map[9, 7] = 9;

            return map;
        }


        static void Main(string[] args)
        {

             int[,] matris = new int[10,10];
             
           
            menu:
            Console.WriteLine("kolay-->1");
            Console.WriteLine("orta-->2");
            Console.WriteLine("zor-->3");
            Console.WriteLine("oyun derecesini girin:");
            int derece = Int32.Parse(Console.ReadLine());
            Console.Clear();
             switch (derece)
            {
                case 1:
                    matris = map1(matris);
                    SudokuClass sudoku = new SudokuClass(matris);
                    sudoku.Oyna();
                    break;
                case 2:
                    matris = map2(matris);
                    SudokuClass sudoku2 = new SudokuClass(matris);
                    sudoku2.map2Goster();
                    break;
                case 3:
                    matris = map3(matris);
                    SudokuClass sudoku3 = new SudokuClass(matris);
                    sudoku3.map3Goster();
                    break;
                default:
                    goto menu;
            }

            //int x = 1;
            //int y = 1;
            //x = Console.CursorLeft;
            //y = Console.CursorTop;
            //ConsoleKeyInfo tuş = Console.ReadKey();
            //do
            //{
            //    ConsoleKeyInfo tuş1 = Console.ReadKey();
            //    if (tuş1.Key == ConsoleKey.DownArrow)
            //        y += 1;
            //    if (tuş1.Key == ConsoleKey.UpArrow)
            //        y -= 1;
            //    if (tuş1.Key == ConsoleKey.RightArrow)
            //        x += 2;
            //    if (tuş1.Key == ConsoleKey.LeftArrow)
            //        x -= 2;

            //    oyun.map1Goster();
            //    Console.SetCursorPosition(x, y);

            //} while (tuş.Key != ConsoleKey.Escape);
            
        }
       
        }
    }

