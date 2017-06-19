using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Parking_Validation
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var registeredCars = new Dictionary<string, string>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(' ');
                var command = input[0];
                var userName = input[1];

                if (command == "register")
                {
                    var licenseNumber = input[2];
                    var isValidNumber = CheckNumberValidaty(licenseNumber);

                    if (registeredCars.ContainsKey(userName))
                    {
                        Console.WriteLine("ERROR: already registered with plate number {0}", registeredCars[userName]);
                    }
                    else if (registeredCars.ContainsValue(licenseNumber))
                    {
                        Console.WriteLine("ERROR: license plate {0} is busy", licenseNumber);
                    }
                    else
                    {
                        if (isValidNumber)
                        {
                            registeredCars[userName] = licenseNumber;
                            Console.WriteLine("{0} registered {1} successfully", userName, licenseNumber);
                        }
                        else
                        {
                            Console.WriteLine("ERROR: invalid license plate {0}", licenseNumber);
                        }

                    }
                }
                else if (command == "unregister")
                {
                    if (!registeredCars.ContainsKey(userName))
                    {
                        Console.WriteLine("ERROR: user {0} not found", userName);
                    }
                    else
                    {
                        Console.WriteLine("user {0} unregistered successfully", userName);
                        registeredCars.Remove(userName);
                    }
                }


            }
            foreach (var kvp in registeredCars)
            {
                var userName = kvp.Key;
                var license = kvp.Value;

                Console.WriteLine("{0} => {1}", userName, license);
            }
        }

        static bool CheckNumberValidaty(string licenseNumber)
        {
            var numberArr = licenseNumber.ToCharArray();

            var checkTrueOrFalse = new List<bool>();

            if (numberArr.Length != 8)
            {
                return false;
            }

            for (int i = 0; i < numberArr.Length; i++)
            {
                if (i < 2 || i > 5)
                {
                    var trueOrFalse = CheckIfLetters(numberArr, i);
                    checkTrueOrFalse.Add(trueOrFalse);
                }
                else
                {
                    var trueOrFalse = CheckIfNumbers(numberArr, i);
                    checkTrueOrFalse.Add(trueOrFalse);
                }
            }
            if (checkTrueOrFalse.Contains(false))
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        static bool CheckIfNumbers(char[] numberArr, int i)
        {
            if ((numberArr[i] >= 48 && numberArr[i] <= 57))
            {
                return true;
            }
            return false;
        }

        static bool CheckIfLetters(char[] numberArr, int i)
        {
            if ((numberArr[i] >= 65 && numberArr[i] <= 90))
            {
                return true;
            }
            return false;
        }
    }
}
