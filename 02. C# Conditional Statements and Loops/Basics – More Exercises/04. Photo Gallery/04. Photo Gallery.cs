using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Photo_Gallery
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            var day = int.Parse(Console.ReadLine());
            var month = int.Parse(Console.ReadLine());
            var year = int.Parse(Console.ReadLine());
            var hours = int.Parse(Console.ReadLine());
            var minutes = int.Parse(Console.ReadLine());
            var size = double.Parse(Console.ReadLine());
            var width = int.Parse(Console.ReadLine());
            var height = int.Parse(Console.ReadLine());

            var format = string.Empty;

            if (size < 1000)
            {
                format = "B";
            }
            else if (size < 1000000)
            {
                format = "KB";
                size = size / 1000;
            }
            else 
            {
                format = "MB";
                size = size / 1000000.0;
            }
            var orientation = string.Empty;

            if (width > height)
            {
                orientation = "landscape";
            }
            else if (width == height)
            {
                orientation = "square";  
            }
            else
            {
                orientation = "portrait";
            }

            Console.WriteLine("Name: DSC_{0:D4}.jpg", number);
            Console.WriteLine("Date Taken: {0:D2}/{1:D2}/{2} {3:D2}:{4:D2}", day, month, year, hours, minutes);
            Console.WriteLine("Size: {0}{1}", size, format);
            Console.WriteLine("Resolution: {0}x{1} ({2})", width,height,orientation);

         

        }
    }
}
