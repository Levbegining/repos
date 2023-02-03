using System;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer.Start();
            Computer.Stop();

            Console.ReadLine();
        }
    }

    static class Computer
    {
        public static string name = "COMP-2020";
        public static int data = 1024;

        // Тут будет ваше поле
        private static int dataKb = 0;


        public static void Start()
        {
            Console.WriteLine("Start!");

            // Вычисления для приватного поля

            dataKb = data * 1024;

            Console.WriteLine("Kb: " + dataKb);
        }

        public static void Stop()
        {
            Console.WriteLine("Stop!");
        }

        public static void Welcome(string name)
        {
            Console.WriteLine("Привет, " + name + "!");
        }
    }
}