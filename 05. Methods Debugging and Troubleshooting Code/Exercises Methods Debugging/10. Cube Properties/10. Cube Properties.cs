using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Cube_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            var side = double.Parse(Console.ReadLine());
            var parameter = Console.ReadLine();
            var output = 0.0;

            if (parameter == "face")
            {
                output = GetFaceDiagonals(side);
            }
            else if (parameter == "space")
            {
                output = GetSpaceDiagonals(side);
            }
            else if (parameter == "volume")
            {
                output = GetVolumeOfCube(side);
            }
            else if (parameter == "area")
            {
                output = GetSurfaceAreaOfCube(side);
            }
            Console.WriteLine("{0:F2}",output);
        }

        static double GetSurfaceAreaOfCube(double side)
        {
            var surfaceArea = 6 * Math.Pow(side, 2);
            return surfaceArea;
        }

        static double GetVolumeOfCube(double side)
        {
            var volume = Math.Pow(side, 3);
            return volume;
        }

        static double GetSpaceDiagonals(double side)
        {
            var spaceDiagonal = Math.Sqrt(3 * Math.Pow(side, 2));
            return spaceDiagonal;
        }

        static double GetFaceDiagonals(double side)
        {
            var faceDiagonal = Math.Sqrt(2 * Math.Pow(side, 2));
            return faceDiagonal;
        }
    }
}
