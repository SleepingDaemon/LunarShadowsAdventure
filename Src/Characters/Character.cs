namespace LunarShadowsAdventure;

public abstract class Character
{
    public string Name { get; protected set; }

    public Character(string name)
    {
        Name = name;
    }
}
