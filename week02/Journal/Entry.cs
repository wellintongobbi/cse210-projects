using System;

public class Entry
{

    public string _date;
    public string _promptText;

    public string _entryText;

    DateTime theCurrentTime;

    PromptGenerator promptGenerator = new PromptGenerator();
    


    public void Display()
    {
        promptGenerator.GeneratePrompt();
        _promptText = promptGenerator._prompt;
        Console.WriteLine(_promptText);
        _entryText = Console.ReadLine();
        theCurrentTime = DateTime.Now;
        _date = theCurrentTime.ToShortDateString();
    }
}