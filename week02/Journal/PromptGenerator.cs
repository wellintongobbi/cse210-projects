using System;

public class PromptGenerator
{

    public string _prompt;
    public void GeneratePrompt()
    {
        string[] prompts =
        {
            "What was the most interesting thing that happened to you today?",
            "Describe a moment today that made you feel grateful.",
            "What challenge did you face today and what did you learn from it?"
        };

        Random random = new Random();
        int index = random.Next(prompts.Length);

        _prompt = prompts[index];
    }
}