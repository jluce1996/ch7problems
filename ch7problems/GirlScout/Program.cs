using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GirlScout
{
    class Program
    {
        static void Main(string[] args)
        {
            GirlScout scout = new GirlScout();
            scout.name = "Lacy";
            scout.dues = 13.01;
            scout.number = 3410;

            GirlScout ranger = new GirlScout("Victoria", 3410, 12.99);

            Console.WriteLine(scout.name + "" + scout.dues + "" + scout.number + "");
            Console.WriteLine(ranger.name + "" +  ranger.dues + "" +  ranger.number + "");
            Console.WriteLine(GirlScout.motto);

        }
    }
}
