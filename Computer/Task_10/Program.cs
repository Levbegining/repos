using System;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer.Start();

            int n = int.Parse(Console.ReadLine());
            bool answer = Computer.IsFreeSpace(n);
            Console.WriteLine("Файл можно записать на компьютер: " + answer);

            Computer.Stop();

            Console.ReadLine();
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

        // Начало метода IsFreeSpace
        public static bool IsFreeSpace(int n)
        {
            if (n <= dataKb)
            {
                return true;
            }
            return false;
        }
        // Окончание метода IsFreeSpace

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
