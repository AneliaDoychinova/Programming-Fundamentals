using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _04.Merge_Files
{
    class Program
    {
        static void Main(string[] args)
        {
            var input1 = File.ReadAllLines("input1.txt");
            var input2 = File.ReadAllLines("input2.txt");

            var outputList = new List<int>();

            for (int i = 0; i < input1.Length; i++)
            {
                outputList.Add(int.Parse(input1[i]));
                outputList.Add(int.Parse(input2[i]));
            }
            outputList.Sort();

            foreach (var num in outputList)
	        {
                File.AppendAllText("output.txt", num + Environment.NewLine);
	        }
            
        }
    }
}
