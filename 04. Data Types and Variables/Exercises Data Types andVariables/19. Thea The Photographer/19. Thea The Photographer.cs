using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.Thea_The_Photographer
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOfPictures = int.Parse(Console.ReadLine());
            var filterTimeInSeconds = int.Parse(Console.ReadLine());
            var filterFactor = int.Parse(Console.ReadLine());
            var timeForUpload = int.Parse(Console.ReadLine());

            var filteredPictures = (long)Math.Ceiling(numberOfPictures * filterFactor * 0.01);
            var totalTimeInSeconds = (long)numberOfPictures * filterTimeInSeconds + filteredPictures * timeForUpload;

            var days = (totalTimeInSeconds / 86400);
            var hours = (totalTimeInSeconds - 86400 * days) / 3600;
            var minutes = (totalTimeInSeconds - 86400 * days - hours * 3600) / 60;
            var seconds = (totalTimeInSeconds - 86400 * days - hours * 3600 - minutes * 60);


            Console.WriteLine("{0}:{1:D2}:{2:D2}:{3:D2}", days, hours, minutes, seconds);

            //var secondsTimeSpan = TimeSpan.FromSeconds(totalTimeInSeconds);
            //Console.WriteLine(secondsTimeSpan.ToString(@"d\:hh\:mm\:ss"));
        }
    }
}
