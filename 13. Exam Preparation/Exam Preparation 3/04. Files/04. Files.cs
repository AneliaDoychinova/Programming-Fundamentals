using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.Files
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var files = new List<File>();

            for (int i = 0; i < n; i++)
            {
                var filePath = Console.ReadLine();
                var regex = new Regex(@"(?<root>.+?)\\(.+\\)*(?<fileName>.+)\.(?<extension>.+);(?<size>[\d]+)");

                Match match = regex.Match(filePath);

                if (match.Success)
                {

                    var root = match.Groups["root"].Value;
                    var fileName = match.Groups["fileName"].Value;
                    var extension = match.Groups["extension"].Value;
                    var size = long.Parse(match.Groups["size"].Value);


                    var hasChanged = false;
                    foreach (var file in files)
                    {
                        if (file.Root == root && file.FileName == fileName && file.Extension == extension &&
                            file.Size != size)
                        {
                            hasChanged = true;
                            file.Size = size;
                        }
                    }
                    if (!hasChanged)
                    {
                        var newFile = new File
                        {
                            Root = root,
                            FileName = fileName,
                            Extension = extension,
                            Size = size
                        };
                        files.Add(newFile);
                    }


                }

            }

            var wantedFiles = Console.ReadLine().Split();
            var wantedRoot = wantedFiles[2];
            var wantedExtension = wantedFiles[0];

            var isFind = false;
            foreach (var file in files.OrderByDescending(a =>a.Size).ThenBy(a => a.FileName))
            {
                if (file.Extension == wantedExtension && file.Root == wantedRoot)
                {
                    isFind = true;
                    Console.WriteLine("{0}.{1} - {2} KB ", file.FileName, file.Extension, file.Size);
                }
            }
            if (!isFind)
            {
                Console.WriteLine("No");
            }
        }

        class File
        {
            public string Root { get; set; }

            public string FileName { get; set; }

            public string Extension { get; set; }

            public long Size { get; set; }
        }
    }
}
