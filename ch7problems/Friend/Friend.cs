using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Friend
{
    class Friend : IComparable 
    {
        public string phone {get; set;}
        public int month {get; set;}
        public int day {get; set;}
        public int year {get; set;}
        public int birthday {get; set;}
        public string name;

        public Friend(string name, int month, int year, int day, string phone)
        {
            this.name = name;
            this.month = month;
            this.year = year;
            this.day = day;
            this.phone = phone;
        }

        int IComparable.CompareTo(Object o)
        {
            Friend friend = (Friend)o;

            return this.name.CompareTo(friend.name);
        }
    }
}
