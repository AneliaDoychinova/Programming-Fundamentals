using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Morse_Code_Upgraded
{
    class Program
    {
        static void Main(string[] args)
        {
            var messages = Console.ReadLine().Split('|').ToArray();
            var result = new StringBuilder();


            for (int i = 0; i < messages.Length; i++)
            {
                var currentMessage = messages[i];
                var sum = GetSumOfMessage(currentMessage);
                result.Append((char)sum);
            }

            Console.WriteLine(result.ToString());
        }

        private static int GetSumOfMessage(string currentMessage)
        {
            var count0 = 0;
            var count1 = 0;
            var sum = 0;
            var sequence = 1;
            for (int j = 0; j < currentMessage.Length; j++)
            {
                var currentNum = currentMessage[j];
                if (j < currentMessage.Length - 1)
                {

                    var nextNum = currentMessage[j + 1];
                    if (currentNum == nextNum)
                    {
                        sequence++;
                    }
                    else
                    {
                        if (sequence > 1)
                        {
                            sum += sequence;

                        }
                        sequence = 1;
                    }
                }

                if (currentNum == '0')
                {
                    count0++;
                }
                else
                {
                    count1++;
                }



            }
            if (sequence>1)
            {
                sum += sequence;
            }
            sum += count0 * 3;
            sum += count1 * 5;
            return sum;
        }
    }
}
