using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private Random _random = new Random();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ')
                     .Select(w => new Word(w))
                     .ToList();
    }

    public void HideRandomWords(int numberToHide)
    {
        for (int i = 0; i < numberToHide; i++)
        {
            var visibleWords = _words.Where(w => !w.IsHidden()).ToList();

            if (visibleWords.Count == 0)
                return;

            int index = _random.Next(visibleWords.Count);
            visibleWords[index].Hide();
        }
    }

    public string GetDisplayText()
    {
        string text = _reference.GetDisplayText() + "\n\n";

        foreach (Word word in _words)
        {
            text += word.GetDisplayText() + " ";
        }

        return text.Trim();
    }

    public bool IsCompletelyHidden()
    {
        return _words.All(w => w.IsHidden());
    }
}