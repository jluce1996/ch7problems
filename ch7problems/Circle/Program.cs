using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Circle
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle Round, Rounder, Roundest;


            Round = new Circle();
            Round.Radius = .5;

            Rounder = new Circle();
            Rounder.Radius = 4;

            Roundest = new Circle();
            Roundest.Radius = 1;

            Console.WriteLine(Round.Radius + " " + Round.Diameter + " " + Round.Area + " ");
            Console.WriteLine(Rounder.Radius + " " + Rounder.Diameter + " " + Rounder.Area + " ");
            Console.WriteLine(Roundest.Radius + " " + Roundest.Diameter + " " + Roundest.Area + " ");    
                

        }
    }
}
