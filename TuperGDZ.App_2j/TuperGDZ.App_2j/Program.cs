using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuperGDZ.App_2j
{
    
    internal class Program
    {
        static int mob = 1;
        static int LeftCr = 0;
        static int TopCr = 0;
        static int x = 0;
        static int Left = 0;
        static int LeftCoursor = 24;
        static int TopCoursor = 0;
        static int LeftCoursorPosition = 25;
        static int TopCoursorPositon = 0;
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            while (true)
            {
                for (int i = 0; i < 10; i++)
                {
                    for (int g = 0; g < 10; g++)
                    {
                        Console.SetCursorPosition(Left, 3);
                        Console.WriteLine("__");
                        Left++;
                        if (Left == 100)
                        {
                            Left = x;
                        }
                    }
                    Console.SetCursorPosition(LeftCoursor, TopCoursor);
                    Console.WriteLine("|");
                    TopCoursor = TopCoursor + mob;
                    if (TopCoursor == 3)
                    {
                        TopCoursor = 4;

                    }
                    if (TopCoursor == 8)
                    {
                        TopCoursor = x;
                    }
                }
                Console.SetCursorPosition(LeftCr, TopCr);
                Console.Write("Часть\n(если не знаете,\n то напишите 0): ");
                int chast = int.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine();
                Console.Write("Всего\n(если не знаете,\n то напишите 0): ");
                int col = int.Parse(Console.ReadLine());
                Console.SetCursorPosition(LeftCoursorPosition, TopCoursorPositon);
                Console.Write("Процент который состав. часть(если не знаете, то напишите 0): ");
                int ischast = int.Parse(Console.ReadLine());
                Console.SetCursorPosition(LeftCoursorPosition, TopCoursorPositon + 6);
                Console.Write("Процент, который состав. всего (если не знаете, то то напишите 0): ");
                int iscol = int.Parse(Console.ReadLine());


                if (ischast == x && iscol == x || ischast == x && col == x ||
                    ischast == x && chast == x || iscol == x && col == x ||
                    iscol == x && chast== x || col == x && chast == x ||
                    chast == x && ischast == x && col == x || chast == x && iscol == x && col == x ||
                    ischast == x && iscol == x && chast == x || ischast == x && iscol == x && col == x ||
                    ischast == x && iscol == x && chast == x && col == x)
                {
                    Console.WriteLine();
                    Console.WriteLine("нельзя написать 2,3, или 4 нуля одновременно!");
                    Console.WriteLine("Пожалуйста, попробуйте заного");
                    Console.Write(" напишите что нибудь чтобы продолжить...");
                    string beleberda = Console.ReadLine();
                    Console.Clear();
                }
                else if(ischast != x && iscol != x && chast != x && col != x)
                {
                    Console.WriteLine();
                    Console.WriteLine("Нельзя не написать ни одного нуля!");
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("ЛОООХ");
                    Console.ForegroundColor= ConsoleColor.Blue;
                    Console.WriteLine("Пожалуйста, попробуйте заного");
                    Console.Write(" напишите что нибудь чтобы продолжить...");
                    string beleberda_2 = Console.ReadLine();
                    Console.Clear();
                }
                    if (ischast == x && iscol != x && chast != x && col != x)
                    {
                    Console.WriteLine();
                        Console.WriteLine("Ответ: " + (chast * iscol / col));
                        Console.Write(" напишите что нибудь чтобы продолжить...");
                        string beleberda_3 = Console.ReadLine();
                        Console.Clear();
                    }
                    else if (iscol == x && ischast != x && chast != x && col != x)
                    {
                    Console.WriteLine();
                        Console.WriteLine("Ответ: " + col * ischast / chast);
                        Console.Write(" напишите что нибудь чтобы продолжить...");
                        string beleberda_4 = Console.ReadLine();
                        Console.Clear();
                    }
                    else if (chast == x && ischast != x && iscol != x && col != x)
                    {
                    Console.WriteLine();
                        Console.WriteLine("Ответ: " + (col * ischast / iscol));
                        Console.Write(" напишите что нибудь чтобы продолжить...");
                        string beleberda_5 = Console.ReadLine();
                        Console.Clear();
                    }
                    else if (chast != x && ischast != x && iscol != x && col == x)
                    {
                    Console.WriteLine();
                        Console.WriteLine("Ответ: " + (chast * iscol / ischast));
                        Console.Write(" напишите что нибудь чтобы продолжить...");
                        string beleberda_6 = Console.ReadLine();
                        Console.Clear();
                    }

            }
            Console.ReadLine();
        }
    }
}
