using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var time = new SimpleTime(15, 30, 19);
            Console.WriteLine(time.BuildString());
            Console.ReadLine();
        }
    }

    class SimpleTime
    {
        private int hour; //0-23
        private int minute; //0-59
        private int second; // 0-59

        public SimpleTime(int hour, int minute, int second)
        {
            this.hour = hour; // set 'this object's hour instance variab;e
            this.minute = minute; // set 'this' object's minute
            this.second = second; // set 'this object's second
        }

        //use explicit and implicit 'this' to call ToUniversalString
        public string BuildString() =>
            $"{"this.ToUniversalString()",24}: {this.ToUniversalString()}" +
            $"\n{"ToUniversalString()",24} : {ToUniversalString()}";

        //Convert to string in universal time format (HH:MM:SS);
        //"this" is not required here to access instance variables,
        //because the method does not have local variables with the same
        // name as the instance variable
        public string ToUniversalString() =>
            $"{this.hour:D2}:{this.minute:D2}:{this.second:D2}";
    }
}
