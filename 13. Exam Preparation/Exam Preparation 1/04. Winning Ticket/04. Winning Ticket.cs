using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Winning_Ticket
{
    class Program
    {
        static void Main(string[] args)
        {
            var tickets = Console.ReadLine()
                .Split(", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            foreach (var ticket in tickets)
            {
                if (ticket.Length != 20)
                {
                    Console.WriteLine("invalid ticket");
                    continue;
                }
                var leftPart = ticket.Substring(0, 10);
                var rightPart = ticket.Substring(10);

                var leftLongestSeq = FindLongestSeq(leftPart);
                var rightLongestSeq = FindLongestSeq(rightPart);

                var areEqualSigns = leftLongestSeq[0] == rightLongestSeq[0];
                var areSignsValid = (leftLongestSeq[0] == '$') || (leftLongestSeq[0] == '@') || 
                    (leftLongestSeq[0] == '^') || (leftLongestSeq[0] == '#');
                
                if (areSignsValid && leftLongestSeq.Length >=6 && rightLongestSeq.Length >= 6 && areEqualSigns)
                {
                    var count = Math.Min(leftLongestSeq.Length, rightLongestSeq.Length);

                    Console.Write("ticket \"{0}\" - {1}{2}", ticket, count, leftLongestSeq[0]);

                    if (count == 10)
                    {
                        Console.Write(" Jackpot!");
                    }
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("ticket \"{0}\" - no match", ticket);
                }
            }
        }

       static string FindLongestSeq(string part)
        {
            var currentLenght = 1;
            var bestLenght = 1;
            char bestChar = '!';
            char currentChar;

            for (int i = 1; i <= part.Length -1; i++)
            {
                if (part[i] == part[i-1])
                {
                    currentLenght++;
                    if (currentLenght > bestLenght)
                    {
                        bestLenght = currentLenght;
                        bestChar = part[i];
                    }
                }
                else
                {
                    currentChar = part[i];
                    currentLenght = 1;
                }
            }
            return new string(bestChar,bestLenght);
        }
    }
}
