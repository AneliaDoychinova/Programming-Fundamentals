using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _06.Fix_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
           var input = File.ReadAllLines("input.txt");

            var emails = new Dictionary<string, string>();

            for (int i = 0; i < input.Length; i+=2)
			{
                var name = input[i];
                var email = input[i+1];
                emails[name] = email;
			}

            var fixedEmails = emails.Where(a => !(a.Value.EndsWith("us") || a.Value.EndsWith("uk"))).
                ToDictionary(a => a.Key, a => a.Value);

            foreach (var kvp  in fixedEmails)
	        {
		        var name = kvp.Key;
                var email = kvp.Value;

                File.AppendAllText("output.txt", name + " -> " + email + Environment.NewLine);
	        }
        }
    }
}
