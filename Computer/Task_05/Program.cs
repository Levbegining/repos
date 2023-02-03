using System;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer.Start();

            Computer.Welcome("Илья");

            Console.WriteLine("Имя компьютера: " + Computer.name);

            Computer.Stop();

            Console.ReadLine();
        }
    }

    // Тут будет ваш код
    public static class Computer
    {
        //Fields
        public static string name = "COMP-2020";


        // Methods
        public static void Start()
        {
            Console.WriteLine("Start!");
        }
        public static void Stop()
        {
            Console.WriteLine("Stop!");
        }
        public static void Welcome(string name)
        {
            Console.WriteLine("Hello, " + name);
        }
    }
}