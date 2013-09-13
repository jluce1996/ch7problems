using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SchoolsDemo
{
    class Program
    {
        public static void GetData(out string schoolname, out int enrollment)
        {
            string input;
           
            Console.Write("Enter the enrollment: ");
            input = Console.ReadLine();
            enrollment = Convert.ToInt32(input);

            Console.Write("Enter the schoolname: ");
            input = Console.ReadLine();
            schoolname = Convert.ToString(input);
        }



        static void Main(string[] args)
        {
            string schoolname;
            int enrollment;
            int i;
                      
            School[] school = new School[5];
           
            for(i = 0; i < school.Length; i++)
            {
                GetData(out schoolname, out enrollment);

                school[i] = new School(schoolname, enrollment);
            }

            Array.Sort(school);
            Console.WriteLine("Sorted List:");

            for (i = 0; i < school.Length; i++)
            {
                Console.WriteLine(school[i].schoolname);
            }
        }
    }
}
