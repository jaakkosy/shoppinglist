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
            PrintShoppingList(lines);
            CollectShoppingList(filePath,lines);
            PrintShoppingList(lines);
        }

        // printing shopping list contents
        public static List<string> PrintShoppingList(List<string> lines)
        {
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
            return lines;
        }

        // collecting shopping list contents from user
        public static List<string> CollectShoppingList(string filePath,List<string> lines)
        {
            while (true)
            {

                Console.WriteLine("Write the product in the shoppinglist, to exit, write 'exit'");
                string userInput;
                try
                {
                    userInput = Console.ReadLine();
                }
                catch (Exception)
                {
                    Console.WriteLine("Enter input in correct form");
                    continue;
                }
                if (userInput.ToLower() == "exit")
                {
                    return lines;
                }
                lines.Add(userInput);
                File.WriteAllLines(filePath, lines);
                continue;
            }
        }
    }
}
