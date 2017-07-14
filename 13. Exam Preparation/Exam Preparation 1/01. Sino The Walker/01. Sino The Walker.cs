using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Numerics;
namespace _01.Sino_The_Walker
{
    class Program
    {
        static void Main(string[] args)
        {
            var arrivalTime = DateTime.ParseExact(Console.ReadLine(),"H:m:s", CultureInfo.InvariantCulture);
           
            var stepsNum = int.Parse(Console.ReadLine());
            var secondsPerStep = int.Parse(Console.ReadLine());
            long addSeconds = (long)stepsNum * secondsPerStep;
            var days = 24 * 60 * 60;
            addSeconds = addSeconds % days;
            var time = arrivalTime.AddSeconds(addSeconds);
            
            Console.WriteLine("Time Arrival: {0}" ,time.ToString("HH:mm:ss"));
        }
    }
}
