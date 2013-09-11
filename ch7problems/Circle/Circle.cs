using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Circle
{
    class Circle
    {
        double radius;
        double area;
        double diameter;

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
                diameter = radius * 2;
                area = radius * radius * Math.PI;
            }
        }

        public double Diameter
        {
            get
            {
                return diameter;
            }
        }

        public double Area
        {
            get
            {
                return area;
            }
        }


        


            
    }
}
