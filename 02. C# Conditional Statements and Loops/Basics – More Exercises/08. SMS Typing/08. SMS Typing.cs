using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.SMS_Typing
{
    class Program
    {
        static void Main(string[] args)
        {
            var charactersNum = int.Parse(Console.ReadLine());

            var characters = new char[] {' ', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p',
            'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};
            var charactesNum = new int[] {0, 2,22,222,3,33,333,4,44,444, 5,55,555,6,66,666,7,77,777,7777,8,88,888,
                9,99,999,9999};

            var output = string.Empty;

            for (int i = 0; i < charactersNum; i++)
            {
                var character = int.Parse(Console.ReadLine());

                for (int j = 0; j < charactesNum.Length; j++)
                {
                    if (charactesNum[j] == character)
                    {
                        output += characters[j];
                    }
                }
            }

            Console.WriteLine(output);
        }
    }
}
