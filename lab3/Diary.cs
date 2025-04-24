using System;
using System.IO;

namespace DigitalDiary
{
    public class Diary
    {
        private readonly string filePath = "diary.txt";

        public void WriteEntry(string text)
        {
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                string entry = $"Date: {DateTime.Now:yyyy-MM-dd HH:mm:ss}\n{text}\n---\n";
                writer.WriteLine(entry);
            }
        }

        public void ViewAllEntries()
        {
            if (File.Exists(filePath))
            {
                string content = File.ReadAllText(filePath);
                Console.WriteLine("\nAll Diary Entries:\n");
                Console.WriteLine(content);
            }
            else
            {
                Console.WriteLine("No diary entries found.");
            }
        }

        public void SearchByDate(string date)
        {
            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);
                bool found = false;

                foreach (string line in lines) 
                {
                    if (line.Contains($"Date: {date}"))
                    {
                        found = true;
                        Console.WriteLine("\nEntry Found:\n");
                        Console.WriteLine(line);

                        int index = Array.IndexOf(lines, line);
                        for (int i = index + 1; i < lines.Length && lines[i] != "---"; i++)
                        {
                            Console.WriteLine(lines[i]);
                        }
                        Console.WriteLine("---\n");
                    }
                }

                if (!found)
                {
                    Console.WriteLine($"No entries found for date: {date}");
                }
            }
            else
            {
                Console.WriteLine("No diary entries found.");
            }
        }
    }
}