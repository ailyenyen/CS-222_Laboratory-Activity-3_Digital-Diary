using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Antenor__Bunquin__Carranza__Mallen
{
    class Diary
    {
        private static string filepath = "diary.txt";

        private static void EnsureFileExist()
        {
            if (!File.Exists(filepath))
            {
                File.Create(filepath).Close();
            }
        }
        public void WriteEntry(string text)
        {
            EnsureFileExist();

            using (StreamWriter writer = new StreamWriter(filepath, true))
            {
                string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                writer.WriteLine($"{timestamp} | {text}{Environment.NewLine}");
            }
            
            Console.WriteLine("Entry saved successfully.");
        }

        public void ViewAllEntries()
        {
            EnsureFileExist();

            using (StreamReader reader = new StreamReader(filepath))
            {
                string? line;
                int num = 0;
                bool hasEntries = false;

                while ((line = reader.ReadLine()) != null)
                {
                    if (!string.IsNullOrWhiteSpace(line))
                    {
                        Console.WriteLine($"{++num}. {line}");
                        hasEntries = true;
                    }
                }

                if (!hasEntries)
                {
                    Console.WriteLine("No entries found.");
                }
            }

        }

        public void SearchByDate(string date)
        {
            EnsureFileExist();

            using (StreamReader reader = new StreamReader(filepath))
            {
                string line;
                bool found = false;

                while ((line = reader.ReadLine()) != null)
                {
                    if (line.StartsWith(date))
                    {
                        Console.WriteLine(line);
                        found = true;
                    }
                }

                if (!found)
                {
                    Console.WriteLine($"No entries found for {date}.");
                }
            }
        }

        public void DeleteEntry(int entryNumber)
        {
            EnsureFileExist();
            List<string> lines = new List<string>(File.ReadAllLines(filepath));

            if (entryNumber < 1 || entryNumber > lines.Count)
            {
                Console.WriteLine("Invalid entry number.");
                return;
            }

            lines.RemoveAt(entryNumber - 1);
            File.WriteAllLines(filepath, lines);
            Console.WriteLine("Entry deleted successfully.");
        }

        public void ModifyEntry(int entryNumber, string newText)
        {
            EnsureFileExist();
            string[] allLines = File.ReadAllLines(filepath);
            List<string> validEntries = allLines.Where(line => !string.IsNullOrWhiteSpace(line)).ToList();

            if (entryNumber < 1 || entryNumber > validEntries.Count)
            {
                Console.WriteLine("Invalid entry number.");
                return;
            }

            string oldEntry = validEntries[entryNumber - 1];
            string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            string updatedEntry = $"{timestamp} | {newText}";

            for (int i = 0, entryIndex = 0; i < allLines.Length; i++)
            {
                if (!string.IsNullOrWhiteSpace(allLines[i]))
                {
                    if (entryIndex == entryNumber - 1)
                    {
                        allLines[i] = updatedEntry;
                        break;
                    }
                    entryIndex++;
                }
            }

            File.WriteAllLines(filepath, allLines);
            Console.WriteLine("Entry modified successfully.");
        }

    }
}
