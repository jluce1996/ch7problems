using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Circle
{
    class Circle
    {
        double radius;

        public Circle()
        {
            radius = 1;
        }

        public double Radius
        {
            get
            {
                return radius;
            }
            set
            {
                radius = value;
            }
        }

        public double Diameter
        {
            get
            {
                return radius * 2;
            }
        }

        public double Area
        {
            get
            {
                return radius * radius * Math.PI;
            }
        }


        


            
    }
}
