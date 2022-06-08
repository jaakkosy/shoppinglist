using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingList
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\JaakkoSyrjämäki\source\repos\ShoppingList\shoppinglist.txt";
            List<string> lines = File.ReadAllLines(filePath).ToList();

            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
            while (true)
            {

                Console.WriteLine("Write the product in the shoppinglist, to exit, write exit");
                string userInput = Console.ReadLine();
                if (userInput.ToLower() == "exit")
                {
                    break;
                }
                lines.Add(userInput);
                File.WriteAllLines(filePath, lines);
            }
        }
    }
}
