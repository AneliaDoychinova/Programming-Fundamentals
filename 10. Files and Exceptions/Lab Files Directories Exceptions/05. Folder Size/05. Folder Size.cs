using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _05.Folder_Size
{
    class Program
    {
        static void Main(string[] args)
        {
            var filesInDir = Directory.GetFiles("TestFolder");

            var sum = 0.0;

            foreach (var file in filesInDir)
            {
                var fileInfo = new FileInfo(file);

                sum += fileInfo.Length;
            }

            sum = sum / 1024 / 1024;

            File.WriteAllText("output.txt", Convert.ToString(sum));
        }
    }
}
