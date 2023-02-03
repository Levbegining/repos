using System;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer.Start();      // вкл компьютер
            Computer.Stop();       // выкл компьютер
            Console.WriteLine(Computer.data);
            Console.ReadLine();
        }
    }

    public static class Computer
    {
        //fields
        public static int data = 1024;


        //methods
        public static void Start()
        {
            Console.WriteLine("Start!");
        }
        public static void Stop()
        {
            Console.WriteLine("Stop!");
        }
    }
}