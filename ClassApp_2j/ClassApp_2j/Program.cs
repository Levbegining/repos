using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassApp_2j
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BatCar.color = "синий";
            Console.WriteLine(BatCar.color);
            Console.WriteLine(BatCar.isheating);

            BatCar.Bibi();
            BatCar.OpenDoors();

            Console.ReadLine();
        }
        static class BatCar
        {
            // fields
            public static string color;
            public static bool isheating;

            // methods

            public static void Bibi()
            {
                Console.WriteLine("би-би-би");
            }

            public static void OpenDoors()
            {
                Console.WriteLine("бит мобил опэнэроу двире!");
            }
        }
        class SliceOfBread
        {
            public string color;
            public bool isheating;
        }
    }
}
