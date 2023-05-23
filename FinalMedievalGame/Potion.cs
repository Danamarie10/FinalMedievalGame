using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FinalMedievalGame
{
    public class Potion
    {
        static List<string> potions = new List<string>();
        public static void AddPotion()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Add the Health Potion to Inventory?");
            Console.Write("Type 'Health Potion' to Add to inventory: ");
            Console.ResetColor();
            string potion = Console.ReadLine();
            potions.Add(potion);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Health potion added Successfully!");
            Console.ReadKey();
            
        }
        public static void ViewInventory()
        {
            Console.ForegroundColor= ConsoleColor.Yellow;
            if (potions.Count > 0)
            {
                Console.Write("Select Potion (1-4): ");

                for (int i = 0; i < potions.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {potions[i]}");
                }
            }
            else
            {
                Console.WriteLine("No Potions Found");
            }

            }
           public static void RemovePotion()
            {
            
                if (potions.Count > 0)
                {
                Console.ForegroundColor= ConsoleColor.Yellow;
                    Console.Write("Enter the potion to remove(1-4): ");
                    if (int.TryParse(Console.ReadLine(), out int potionNumber))
                    {
                        if (potionNumber > 0 && potionNumber <= potions.Count)
                        {
                            string removedTask = potions[potionNumber - 1];
                            potions.RemoveAt(potionNumber - 1);
                            Console.ResetColor();
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"'{removedTask}' removed successfully!");
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.WriteLine("Invalid potion number. Please enter a valid potion number.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid potion number");
                    }
                }
                else
                {
                    Console.WriteLine("No potions found.");
                }
        }
    }
}
