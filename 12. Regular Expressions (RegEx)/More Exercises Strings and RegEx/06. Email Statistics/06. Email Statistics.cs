using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _06.Email_Statistics
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            
            var regex = @"^(?<username>[a-zA-Z]{5,})@(?<mailServer>[a-z]{3,})(?<domain>\.com|\.bg|\.org)$";
           
            var dictOfDomains = new Dictionary<string, List<string>>();
           
            for (int i = 0; i < n; i++)
            {
                var email = Console.ReadLine();
                Match match = Regex.Match(email, regex);
                if (match.Success)
                {
                    var username = match.Groups["username"].Value;
                    var domain = match.Groups["mailServer"].Value;
                    var domainHost = domain + email.Substring(username.Length+domain.Length+1);

                    if (!dictOfDomains.ContainsKey(domainHost))
                    {
                        dictOfDomains[domainHost] = new List<string>();
                    }
                    if (!dictOfDomains[domainHost].Contains(username))
                    {
                        dictOfDomains[domainHost].Add(username);   
                    }
                    
                }
            }

            foreach (var domain in dictOfDomains.OrderByDescending(a => a.Value.Count))
            {
                Console.WriteLine("{0}:",domain.Key);

                foreach (var username in domain.Value)
                {
                    Console.WriteLine("### {0}", username);
                }
            }
        }
    }
}
