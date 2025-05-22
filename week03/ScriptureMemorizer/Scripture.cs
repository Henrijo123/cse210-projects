using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using System.Text;

public class Scripture
{
    private Reference _reference;
    private List<Word> _word = [];

    public Scripture(Reference Reference, string text)
    {
        _reference = Reference;
        string[] words = text.Split(" ");
        foreach (string line in words)
        {
            Word wordList = new Word(line);
            _word.Add(wordList);
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        Random rnd = new Random();
        List<int> numbers = Enumerable.Range(0, _word.Count).ToList();
        numbers = numbers.OrderBy(x => rnd.Next()).ToList();
        int hiddenNumbers = 0;
        foreach (int i in numbers)
        {
            if (!_word[i].IsHidden())
            {
                _word[i].Hide();
                hiddenNumbers++;
                if (hiddenNumbers == numberToHide)
                {
                    break;
                }
            }
        }
    }
    public string GetDisplayText()
    {
        StringBuilder result = new StringBuilder();
        foreach (Word line in _word)
        {
            result.Append($"{line.GetDisplayText()} ");
        }
        return result.ToString().Trim();
    }
    public bool IsCompletelyHidden()
    {
        List<bool> bools = [];
        foreach (Word word in _word)
        {
            bools.Add(word.IsHidden());

        }
        if (bools.Contains(false))
        {
            return false;
        }
        else
        {
            return true;
        }
    }
}