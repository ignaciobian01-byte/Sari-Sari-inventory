using System;

namespace Sari_Sari_Inventory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Sari-Sari Store Inventory System");

            Console.WriteLine("Enter 1 - for May-ari Login");
            Console.WriteLine("Enter 2 - for Bantay Login");
            Console.WriteLine("Enter x - to exit");


            Console.Write("User Input: ");

            string ownerCode = "MayAri2026";
            string checkLogin = Console.ReadLine();

            string itemName = "Cheezy Pula";
            int itemStock = 50;

            while (checkLogin != "x")
            {
                if (checkLogin == "1")
                {
                    Console.Write("Enter owner code: ");
                    string ownerInput = Console.ReadLine();

                    if (ownerCode == ownerInput)
                    {
                        Console.Write("Enter the item name you want to restock: ");

                        string checkItemName = Console.ReadLine();

                        if (checkItemName == itemName)
                        {
                            Console.Write("Enter quantity to add: ");
                            int stockToAdd = Convert.ToInt16(Console.ReadLine());
                            itemStock += stockToAdd;
                        }
                    }

                }
                else if (checkLogin == "2")
                {
                    Console.Write("Enter the item name you want to check: ");

                    string userInput = Console.ReadLine();
                    bool response = userInput == itemName;

                    if (response)
                    {
                        Console.WriteLine("Item found!!");

                        Console.WriteLine("Type 1 - to view stock");
                        Console.WriteLine("Type 2 - to sell item");
                        Console.WriteLine("Type 3 - to exit");

                        Console.Write("Enter your option:");
                        int choice = Convert.ToInt16(Console.ReadLine());

                        switch (choice)
                        {
                            case 1:
                                Console.WriteLine($"Current stock for {itemName} is {itemStock}");
                                break;
                            case 2:
                                Console.WriteLine("Sell item feature is still in progress...");
                                break;
                            case 3:
                                Console.WriteLine("Thank you for using Sari-Sari Store Inventory System");
                                break;
                            default:
                                Console.WriteLine("Incorrect input...");
                                break;
                        }
                    }
                }
                Console.WriteLine("Enter 1 - for May-ari Login");
                Console.WriteLine("Enter 2 - for Bantay Login");
                Console.WriteLine("Enter x - to exit");
                Console.Write("User Input: ");
                checkLogin = Console.ReadLine();
            }
        }
    }
}
