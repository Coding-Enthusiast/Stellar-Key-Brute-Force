using System;
using System.Collections.Generic;
using System.IO;

namespace Stellar_Key_Brute_Force
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string[] keys = File.ReadAllLines(@"C:\keys.txt");
                List<string> validKeys = new List<string>();
                foreach (var key in keys)
                {
                    if (Base32.IsValid(key))
                    {
                        validKeys.Add(key);
                        Console.WriteLine($"Found a valid key: {key}");
                    }
                }

                File.WriteAllLines(@"c:\validkeys.txt", validKeys.ToArray());
            }
            catch (Exception ex)
            {
                Console.WriteLine("An Error occured!");
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }
    }
}
