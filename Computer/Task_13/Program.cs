using System;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer.Start();

            long num = long.Parse(Console.ReadLine());

            Console.WriteLine(Computer.NumDigits(num));

            Console.ReadLine();
        }

        static bool TestFreeSpace(int n)
        {
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += int.Parse(Console.ReadLine());
            }

            Console.WriteLine(sum);
            return Computer.IsFreeSpace(sum);
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

        // Начало метода NumDigits
        public static long NumDigits(long a)
        {
            long sum = 0;
            while (a != 0)
            {
                a = a / 10;
                sum++;
            }
            if (sum == 0)
            {
                sum = 1;
            }
            return sum;
        }
        // Окончание метода NumDigits

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
