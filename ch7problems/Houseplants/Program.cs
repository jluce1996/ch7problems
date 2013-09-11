using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Houseplants
{
    class Program
    {
        static void Main(string[] args)
        {
            Houseplant Daisy, Rose, Tulip;

            Daisy = new Houseplant();
            Daisy.Plantname = "daisy";
            Daisy.Price = 13.99;
            Daisy.Isfed = true;

            Rose = new Houseplant();
            Rose.Plantname = "rose";
            Rose.Price = 15.99;
            Rose.Isfed = true;

            Tulip = new Houseplant();
            Tulip.Plantname = "tulip";
            Tulip.Price = 20.99;
            Tulip.Isfed = true;



            }
        }
    }

