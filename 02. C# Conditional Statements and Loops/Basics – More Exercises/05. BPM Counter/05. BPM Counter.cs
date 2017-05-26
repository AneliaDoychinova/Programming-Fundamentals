using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.BPM_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            var bmp = int.Parse(Console.ReadLine());
            var numberOfBeats = double.Parse(Console.ReadLine());

            var bars = Math.Round(numberOfBeats / 4,1);
            var lenght = 60 * numberOfBeats / bmp;
            var minutes = (int)lenght / 60;
            var seconds = (int)lenght % 60;

            Console.WriteLine("{0} bars - {1}m {2}s", bars, minutes,seconds);
        }
    }
}
