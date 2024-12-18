using System.Text;

namespace LunarShadowsAdventure;

public abstract class Language
{
    public string ChooseName { get; protected set; } = "";
    public string DefaultName { get; protected set; } = "";
    protected virtual void SceneOne()
    {
        throw new Exception("Scene 1 has no content.");
    }
}
