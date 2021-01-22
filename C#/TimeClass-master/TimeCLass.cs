using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeClass
{
    class TimeCLass
    {
        public int Hour { get; set; }//0-23
        public int Minute { get; set; }//0-59
        
        public int Second { get; set; } //0-59

        //Set a new time value using Universal time;
        //Throw an exception if the hour, minute or second is invalid

        public void SetTime(int hour, int minute, int second)
        {
            //vallidate hour, minute and second
            if((hour<0 || hour>23) || (minute <0 || minute >59) || (second<0 || second>59))
            {
                throw new ArgumentOutOfRangeException();
            }

            Hour = hour;
            Minute = minute;
            Second = second;
        }

        //Convert to string in universal-time format (HH:MM:SS)
        public string ToUniversalStrin() => $"{Hour:D2}:{Minute:D2}:{Second:D2}";

        //convert to string in standard-time format (H:MM:SS AM or PM
        public override string ToString() => $"{((Hour == 0  || Hour ==12) ? 12: Hour % 12)}:" + 
            $"{Minute:D2}:{Second:D2} {(Hour < 12 ? "AM" : "PM")}";
    }
}
