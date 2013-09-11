using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Houseplants
{
    class Houseplant
    {
        string plantname;
        double price;
        bool isfed;
        
        public string Plantname
        {
            get
            {
            return plantname;
            }
            set
            {
            plantname = value;
            }
        }

        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }

        public bool Isfed
        {
            get
            {
                return isfed;
            }
            set
            {
                isfed = value;
            }
        }


    }
}
