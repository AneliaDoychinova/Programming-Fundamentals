using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Neighbour_Wars
{
    class Program
    {
        static void Main(string[] args)
        {
            var peshosDamage = int.Parse(Console.ReadLine());
            var goshosDamage = int.Parse(Console.ReadLine());

            var peshoCurrentHealth = 100;
            var goshoCurrentHealth = 100;
            var round = 0;
            var name = string.Empty;

            for (int i = 1;; i++)
            {
                

                if (i % 2 == 1)
                {
                    name = "Pesho";
                    goshoCurrentHealth = goshoCurrentHealth - peshosDamage;
                    round++;
                    if (goshoCurrentHealth <= 0)
                    {
                        break;
                    }
                    Console.WriteLine("{0} used Roundhouse kick and reduced Gosho to {1} health.",name, goshoCurrentHealth);
                }
                else if(i % 2 == 0)
                {
                    name = "Gosho";
                    peshoCurrentHealth = peshoCurrentHealth - goshosDamage;
                    round++;
                    if (peshoCurrentHealth <=0)
                    {
                        break;
                    }
                    Console.WriteLine("{0} used Thunderous fist and reduced Pesho to {1} health.",name, peshoCurrentHealth);
                }
                if (i % 3 == 0)
                {
                    goshoCurrentHealth += 10;
                    peshoCurrentHealth += 10;
                }

                
            }
                 
                    if (goshoCurrentHealth <= 0)
                    {
                        name = "Pesho";
                    }
                    else
                    {
                        name = "Gosho";
                    }
                    Console.WriteLine("{0} won in {1}th round.", name, round);
                   
                
        }
    }
}
