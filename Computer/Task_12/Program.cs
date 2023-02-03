using System;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer.Start();

            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(TestFreeSpace(n));

            Console.ReadLine();
        }

        // Начало вашего кода
        public static bool TestFreeSpace(int n)
        {
            int sum_failes = 0;
            int[] Summa_n = new int[n];
            for (int i = 0; i < n; i++)
            {
                Summa_n[i] = int.Parse(Console.ReadLine());
                sum_failes += Summa_n[i];
            }
            Console.WriteLine(sum_failes);
            int kolInKb = Computer.data * 1000;
            if (sum_failes <= Computer.data)
            {
                return true;
            }
            return false;
        }
        // Окончание вашего кода

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
