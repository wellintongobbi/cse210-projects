using System;
using System.Collections.Generic;
using System.IO;
public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry()
    {
        Entry entry = new Entry();
        entry.Display();
        _entries.Add(entry);
    }
    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            Console.WriteLine($"Date: {entry._date}");
            Console.WriteLine($"Prompt: {entry._promptText}");
            Console.WriteLine($"Entry: {entry._entryText}");
            Console.WriteLine();
        }
    }
    public void SaveToFile()
    {
        Console.WriteLine("Enter the file name:");
        string fileName = Console.ReadLine();

        using (StreamWriter output = new StreamWriter(fileName))
        {
            foreach (Entry entry in _entries)
            {
                output.WriteLine($"{entry._date}|{entry._promptText}|{entry._entryText}");
            }
        }

        Console.WriteLine("Journal saved successfully.");
    }

    public void LoadFromFile()
    {
        Console.WriteLine("Enter the file name:");
        string fileName = Console.ReadLine();

        string[] lines = File.ReadAllLines(fileName);

        _entries.Clear();

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");

            Entry entry = new Entry();
            entry._date = parts[0];
            entry._promptText = parts[1];
            entry._entryText = parts[2];

            _entries.Add(entry);
        }

        Console.WriteLine("Journal loaded successfully.");
    }
}