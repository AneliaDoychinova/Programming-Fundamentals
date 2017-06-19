using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Fix_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            var emails = new Dictionary <string,string>();

            var input = Console.ReadLine();
         
            while (input != "stop")
            {
               var name = input;
               emails[name] = Console.ReadLine();
               input = Console.ReadLine();
            }

           var fixedEmails = RemoveNevalidEmails(emails);

            PrintResult(fixedEmails);


        }

        static void PrintResult(Dictionary<string, string> emails)
        {
            foreach (var kvp in emails)
            {
                Console.WriteLine("{0} -> {1}", kvp.Key,kvp.Value);
            }
        }

        static Dictionary<string,string> RemoveNevalidEmails(Dictionary<string, string> emails)
        {
            var fixedEmails = emails
                .Where(a => !(a.Value.EndsWith("us") || a.Value.EndsWith("uk")))
                .ToDictionary(a => a.Key, a => a.Value);
            return fixedEmails;
        }
    }
}
