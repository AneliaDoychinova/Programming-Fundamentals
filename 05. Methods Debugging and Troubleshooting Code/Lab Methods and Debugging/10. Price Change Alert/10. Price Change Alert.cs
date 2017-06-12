using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Price_difference_Alert
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double threshold = double.Parse(Console.ReadLine());
            double lastPrice = double.Parse(Console.ReadLine());

            for (int i = 0; i < n - 1; i++)
            {
                double currentPrice = double.Parse(Console.ReadLine());
                double percentageDiff = GetDiffInPercentage(lastPrice, currentPrice);
                bool isSignificantDifference = IsThereDiff(percentageDiff, threshold);



                string message = GetOutputMessage(currentPrice, lastPrice, percentageDiff, isSignificantDifference);
                
                Console.WriteLine(message);

                lastPrice = currentPrice;
            }
        }

        static string GetOutputMessage(double currentPrice, double lastPrice, double difference, bool isSignificantDifference)
        {
            string output = string.Empty;

            if (difference == 0)
            {
                output = string.Format("NO CHANGE: {0}", currentPrice);
            }
            else if (!isSignificantDifference)
            {
                output = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, difference * 100);
            }
            else if (isSignificantDifference && (difference > 0))
            {
                output = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, difference * 100);
            }
            else if (isSignificantDifference && (difference < 0))
            {
                output = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, difference * 100);
            }
            return output;
        }
        static bool IsThereDiff(double diff, double treshold)
        {
            if (Math.Abs(diff) >= treshold)
            {
                return true;
            }
            return false;
        }

        static double GetDiffInPercentage(double lastPrice, double currentPrice)
        {
            double percentage = (currentPrice - lastPrice) / lastPrice;
            return   percentage;
;
        }
    }
}
