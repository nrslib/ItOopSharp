using Sample05.Displays;
using Sample05.Rules;

var game = new JankenGame();
game.Play(1, 2, "ja", "default");
game.Play(1, 2, "en", "reverse");

class JankenGame
{
    /// <param name="lang">ja:日本語,en:英語</param>
    /// <param name="ruleName">default:通常,reverse:逆</param>
    public void Play(int leftHand, int rightHand, String lang, String ruleName)
    {
        var rule = GetRule(ruleName);
        var result = rule.Judge(leftHand, rightHand);
        var display = GetDisplay(lang);
        display.Show(result);
    }

    private IRule GetRule(String rule)
    {
        if (rule == "default")
        {
            return new NormalRule();
        }
        else
        {
            return new ReverseRule();
        }
    }

    private IDisplay GetDisplay(String lang)
    {
        if (lang == "ja")
        {
            return new JapaneseDisplay();
        }
        else
        {
            return new EnglishDisplay();
        }
    }
}