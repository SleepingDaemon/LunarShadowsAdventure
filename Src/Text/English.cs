namespace LunarShadowsAdventure;

public class English : Language
{
    public English()
    {
        ChooseName = "What is your name?";
        DefaultName = "No name";
        SceneOne();
    }

    protected override void SceneOne()
    {
        Text.TypeLine("They say the moon pulls at the tides. It tugs at oceans, at rivers... at souls.\n");
        Text.TypeLine("Some are more sensitve to its pull. They lose sleep. They lose time. They lose themselves.\n");
        Text.PromptContinue();
        Text.TypeLine("[The words linger on the screen before fading out.]\n");
        Text.TypeLine(">> A small apartment. The hum of machines drowns the silence.");
        Text.TypeLine(">> The faint smell of stale coffee and warm electronics hangs in the air.");
        Text.TypeLine(">> A programmer—*you*—hunch over your desk, staring at a glowing monitor.");
        Text.PromptContinue();
    }
}
