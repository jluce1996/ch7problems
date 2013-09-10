using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace problem1
{
    class Pizza
    {        
        string toppings;
        int diameter;
        double itemPrice;

        public string Toppings
        {
            get
            {
                return toppings;
            }
            set
            {
                toppings = value;
            }
        }

        public int Diameter
        {
            get
            {
                return diameter;
            }
            set
            {
                diameter = value;
            }
        }

        public double ItemPrice
        {
            get
            {
                return itemPrice;
            }
            set
            {
                itemPrice = value;
            }
        }




    }
}
