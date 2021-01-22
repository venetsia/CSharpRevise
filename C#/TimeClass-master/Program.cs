using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeClass
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create and initialize a TimeClass Object
            var time = new TimeCLass(); //ivokes Time Object Consturctor

            //output string represantations of the time
            Console.WriteLine(
                $"The initial universl timeis: {time.ToUniversalStrin()}");
            Console.WriteLine(
                $"The initial standard time is: {time.ToString()}\n");

            time.SetTime(13, 53, 6);
            Console.WriteLine(
                $"Universal time after SetTime is: {time.ToUniversalStrin()}");
            Console.WriteLine(
                $"Standard time after SetTimes:{time.ToString()}\n");

            //attempt to set time with invalid values
            try
            {
                time.SetTime(99, 99, 99);
            }
            catch(ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message + "\n");
            }

            //Display time after attempt to set invalid values
            Console.WriteLine("After attempting invalid settings:");
            Console.WriteLine($"Universal time: {time.ToUniversalStrin()}");
            Console.WriteLine($"Standard time: {time.ToString()}");

            Console.ReadLine();
        }
    }
}
