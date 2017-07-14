using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _07.Query_Mess
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            var pattern = @"(?<field>[^&=?\s]*)(?=\=)=(?<=\=)(?<value>[^&=\s]*)?";

            while (text != "END")
            {
                var dict = new Dictionary<string, string>();

                MatchCollection matches = Regex.Matches(text, pattern);

                foreach (Match match in matches)
                {
                    string field = match.Groups["field"].Value;
                    field = Regex.Replace(field, @"(%20|\+)+", word => " ").Trim();

                    string value = match.Groups["value"].Value;
                    value = Regex.Replace(value, @"(%20|\+)+", word => " ").Trim();

                    if (!dict.ContainsKey(field))
                    {
                        dict[field] = value;
                    }
                    else
                    {
                        dict[field] += ", " + value;
                    }
                }




                foreach (var field in dict)
                {
                    Console.Write("{0}=[{1}]", field.Key, field.Value);
                }
                Console.WriteLine();

                text = Console.ReadLine();
            }
        }
    }
}
