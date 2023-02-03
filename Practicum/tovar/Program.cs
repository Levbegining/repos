using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tovar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("function: root (x squared times y squared)");
            Console.Write("Write your coordinate x: ");
            Test.x = double.Parse(Console.ReadLine());
            Console.Write("Write your coordinate y: ");
            Test.y = double.Parse(Console.ReadLine());
            double otvet = Test.Distance();
            Console.WriteLine("root (x squared times y squared): "+otvet);
            Console.ReadLine();
        }
    }
    public static class Test
    {
        //fields
        public static double x;
        public static double y;
        //methods
        public static double Distance()
        {
            double kvadrat = x * x + y * y;
            float koren = (float)Math.Sqrt(kvadrat);
            return koren;
        }
    }
}
