using System;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer.Start();

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            int sum = Computer.Add(a, b);
            DecoreAdd(a, b, sum);

            Computer.Stop();

            Console.ReadLine();
        }

        // Начало метода DecoreAdd
        public static void DecoreAdd(int a, int b, int sum)
        {
            sum = a + b;
            Console.WriteLine(a + " + " + b + " = " + sum);
        }
        // Окончание метода DecoreAdd
    }

    static class Computer
    {
        public static string name = "COMP-2020";
        public static int data = 1024;

        private static int dataKb;

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
