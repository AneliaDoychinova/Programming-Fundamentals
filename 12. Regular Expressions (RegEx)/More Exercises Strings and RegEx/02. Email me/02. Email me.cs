using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Email_me
{
    class Program
    {
        static void Main(string[] args)
        {
            var email = Console.ReadLine().Split('@');

            var leftPart = email[0];
            var rightPart = email[1];

            var leftSum = 0;
            var rightSum = 0;

            leftSum = leftPart.ToCharArray().Select(a => (int)a).Sum();
            rightSum = rightPart.ToCharArray().Select(a => (int)a).Sum();

            if (leftSum - rightSum >= 0)
            {
                Console.WriteLine("Call her!");
            }
            else
            {
                Console.WriteLine("She is not the one.");
            }

        }
    }
}
