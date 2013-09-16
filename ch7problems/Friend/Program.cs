using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Friend
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            int i;
            string name;

            Friend[] friend;
            friend = new Friend[7];
            Console.Write("Enter 8 friends names:");
            input = Console.ReadLine();
            Array.Sort(friend);
            Console.WriteLine("Sorted List:");
            for (i = 0; i < friend.Length; i++)
            {
                Console.WriteLine(friend[i].name);
            } 

        }
    }
}
