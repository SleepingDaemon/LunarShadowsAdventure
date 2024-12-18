namespace LunarShadowsAdventure;

public static class Text
{
    private static Language? _language;
    public static Language Language
    {
        get
        {
            if (_language == null)
                throw new Exception("No language loaded.");

            return _language;
        }
    }

    public static void LoadLanguage(Language language)
    {
        _language = language;
    }

    public static void TypeLine(string line)
    {
        for (int i = 0; i < line.Length; i++)
        {
            Console.Write(line[i]);
            Thread.Sleep(30);
        }
    }

    public static void PromptContinue()
    {
        Console.WriteLine("\nPress [Enter] to continue...");
        Console.ReadLine();
    }
}
