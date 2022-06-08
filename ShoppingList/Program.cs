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
            Console.WriteLine("Write the product in the shoppinglist:");
            string userInput = Console.ReadLine();
            lines.Add(userInput);
            File.WriteAllLines(filePath, lines);
        }
    }
}
