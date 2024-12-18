using LunarShadowsAdventure;

Text.LoadLanguage(new English());

Console.WriteLine(Text.Language.ChooseName);

string? name = Console.ReadLine();
var player = new Player(name);

if(name == String.Empty)
    name = Text.Language.DefaultName;

Console.ReadLine();