using System;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            // Старт программы
            Computer.Start();
            int sum_ncch = 0;
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int ncch = int.Parse(Console.ReadLine());
                sum_ncch += ncch;
            }
            Console.WriteLine(sum_ncch);
            Console.WriteLine(Computer.IsFreeSpace(sum_ncch));


            Console.ReadLine();
            // Окончание программы
        }

        static void DecoreAdd(int a, int b, int c)
        {
            Console.WriteLine(a + " + " + b + " = " + c);
        }
    }

    static class Computer
    {
        public static string name = "COMP-2020";
        public static int data = 1024;

        private static int dataKb;

        public static bool IsFreeSpace(int num)
        {
            return data >= num;
        }

        public static void Start()
        {
            Console.WriteLine("Start!");

            dataKb = data * 1024;
            Console.WriteLine("Kb: " + dataKb);
        }

        public static void Stop()
        {
            Console.WriteLine("Stop!");
        }

        public static int Add(int a, int b)
        {
            int sum = a + b;
            return sum;
        }

        public static void Welcome(string name)
        {
            Console.WriteLine("Привет, " + name + "!");
        }
    }
}
