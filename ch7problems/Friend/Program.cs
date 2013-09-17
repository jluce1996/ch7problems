using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Friend
{
    class Program
    {
        public static void GetData(out string name, out int month, out int day, out int year)
        {
            string input;
            
            Console.Write("Enter friend's names: ");
            input = Console.ReadLine();
            name = Convert.ToString(input);
            month = day = year = 0;
            
            Console.Write("Enter their Birthday (00/00/00): ");
            input = Console.ReadLine();

            string[] parts = input.Split('/');
            if (parts.Length == 3)
            {
                month = Convert.ToInt32(parts[0]);
                day = Convert.ToInt32(parts[1]);
                year = Convert.ToInt32(parts[2]);
            }

        }
        static void Main(string[] args)
        {
            string name;
            int month, day, year;
            int i;

            Friend[] friend;
            friend = new Friend[7];
            
            for(i = 0; i < friend.Length; i++)
            {
                GetData(out name, out month, out day, out year);

                friend[i] = new Friend(name, month, day, year);
            }


            Array.Sort(friend);
            Console.WriteLine("Sorted List:");
            for (i = 0; i < friend.Length; i++)
            {
                Console.WriteLine(friend[i].name);
            } 

        }
    }
}
