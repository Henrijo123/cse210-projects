// Added the capacity of creating a csv file by replacing the commas for "|" when writing the file,
// then returning to comas before reading the file.

public class Journal
{
    public List<Entry> _entries = [];
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry i in _entries)
        {
            i.Display();
            Console.WriteLine();
        }
    }

    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            outputFile.WriteLine("date,promptText,entryText");

            foreach (Entry entry in _entries)
            {
                string safePrompt = entry._promptText.Replace(",", "|");
                string safeEntry = entry._entryText.Replace(",", "|");

                outputFile.WriteLine($"{entry._date},{safePrompt},{safeEntry}");
            }
        }
    }

    public void LoadFromFile(string file)
    {
        _entries.Clear();

        string[] lines = System.IO.File.ReadAllLines(file);

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split(",");
            string originalPrompt = parts[1].Replace("|", ",");
            string originalEntry = parts[2].Replace("|", ",");

            Entry loadedEntry = new Entry
            {
                _date = parts[0],
                _promptText = originalPrompt,
                _entryText = originalEntry,
            };
            _entries.Add(loadedEntry);
        }
    }
}