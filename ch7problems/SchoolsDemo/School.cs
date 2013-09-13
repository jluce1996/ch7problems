using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SchoolsDemo
{
    class School : IComparable
    {
        public string schoolname {get; set;}
        public int enrollment {get; set;}

        public School(string schoolname, int enrollment)
        {
            this.enrollment = enrollment;
            this.schoolname = schoolname;
        }

        int IComparable.CompareTo(Object o)
        {
            int returnVal;
            School temp = (School)o;
            if(this.enrollment > temp.enrollment)
                    returnVal = 1;
            else
              if(this.enrollment < temp.enrollment)
                    returnVal = -1;
              else
                returnVal = 0;
            return returnVal;           
        }
        
    }
}
