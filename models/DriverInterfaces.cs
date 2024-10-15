using oop_2024_10_15_group_b_switch_examples.models.superhero;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_2024_10_15_group_b_switch_examples.models
{
    public static class DriverInterfaces
    {
        public static void Run()
        {
            Console.WriteLine("Driver Interface");
        }

        public static void SupermanFlies()
        {
            SuperMan superman = new SuperMan();

           
            Console.WriteLine($"{superman}");

            superman.Fly();
        }

        public static void BatmanFlies()
        {
            Batman batman = new Batman();

            Console.WriteLine($"{batman}");

            batman.Fly();
        }
    }
}
