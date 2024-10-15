using oop_2024_10_15_group_b_switch_examples.models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_2024_10_15_group_b_switch_examples.models.superhero
{
    abstract public class SuperHero
    {
    }

    public class SuperMan : SuperHero, IFly
    {
        public SuperMan() { }

        public void Fly()
        {
            Console.WriteLine("Superman is flying without wings");
        }

        public override string ToString()
        {
            return "SuperMan";
        }
    }

    public class Batman : SuperHero, IFly
    {
        public Batman() { }

        public void Fly()
        {
            Console.WriteLine("Batman is flying with his cape");
        }

        public override string ToString()
        {
            return "Batman";
        }
    }


}
