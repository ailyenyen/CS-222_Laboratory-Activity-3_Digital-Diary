using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using Antenor__Bunquin__Carranza__Mallen;

class Program
{
    static void Main()
    {
        Diary diary = new Diary();

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Diary Application");
            Console.WriteLine("1. Write Entry");
            Console.WriteLine("2. View All Entries");
            Console.WriteLine("3. Search Entry by Date");
            Console.WriteLine("4. Modify an Entry");
            Console.WriteLine("5. Delete an Entry");
            Console.WriteLine("6. Exit");
            Console.Write("Enter choice: ");
            string? choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Console.Write("Enter your diary entry: ");
                    string? entry = Console.ReadLine();
                    diary.WriteEntry(entry ?? "");
                    break;
                case "2":
                    diary.ViewAllEntries();
                    break;
                case "3":
                    Console.Write("Enter date (YYYY-MM-DD): ");
                    string? date = Console.ReadLine();
                    diary.SearchByDate(date ?? "");
                    break;
                case "4":
                    diary.ViewAllEntries();
                    Console.Write("Enter entry number to modify: ");
                    if (int.TryParse(Console.ReadLine(), out int modifyNum))
                    {
                        Console.Write("Enter new text: ");
                        string? newText = Console.ReadLine();
                        diary.ModifyEntry(modifyNum, newText ?? "");
                    }
                    else
                    {
                        Console.WriteLine("Invalid number.");
                    }
                    break;
                case "5":
                    diary.ViewAllEntries();
                    Console.Write("Enter entry number to delete: ");
                    if (int.TryParse(Console.ReadLine(), out int deleteNum))
                    {
                        diary.DeleteEntry(deleteNum);
                    }
                    else
                    {
                        Console.WriteLine("Invalid number.");
                    }
                    break;
                case "6":
                    return;
                default:
                    Console.WriteLine("Invalid choice, please try again.");
                    break;
            }

            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }
        
    }
}
