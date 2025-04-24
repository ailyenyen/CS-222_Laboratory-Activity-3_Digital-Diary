using System;

namespace DigitalDiary
{
    class Program
    {
        static void Main(string[] args)
        {
            Diary diary = new Diary();
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\nDigital Diary Menu");
                Console.WriteLine("1. Write a New Entry");
                Console.WriteLine("2. View All Entries");
                Console.WriteLine("3. Search Entry by Date (YYYY-MM-DD)");
                Console.WriteLine("4. Exit");
                Console.Write("Select an option (1-4): ");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Console.Write("Write your entry: ");
                        string entry = Console.ReadLine();
                        diary.WriteEntry(entry);
                        break;
                    case "2":
                        diary.ViewAllEntries();
                        break;
                    case "3":
                        Console.Write("Enter date to search (YYYY-MM-DD): ");
                        string date = Console.ReadLine();
                        diary.SearchByDate(date);
                        break;
                    case "4":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }
    }
}