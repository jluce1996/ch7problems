using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GirlScout
{
    class GirlScout
    {
        public string name { get; set; }
        public int number { get; set;}
        public double dues { get; set; }
        public const string motto = "to obey the Girl Scout Law";

        public GirlScout()
        {
            name = "Sarah"; 
            number = 3509;
            dues = 19.99;
        }

        public GirlScout(string name, int number, double dues)
        {
            this.name = name;
            this.number = number;
            this.dues = dues;
        }
    }
}
