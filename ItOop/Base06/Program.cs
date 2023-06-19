using Base06.Displays;
using Base06.Rules;

var game = new JankenGame();
game.Play(0, 2, new JapaneseDisplay(), "default");
game.Play(1, 2, new JapaneseDisplay(), "default");
game.Play(2, 2, new JapaneseDisplay(), "default");
game.Play(0, 2, new JapaneseDisplay(), "reverse");
game.Play(1, 2, new JapaneseDisplay(), "reverse");
game.Play(2, 2, new JapaneseDisplay(), "reverse");


class JankenGame
{
    public void Play(int leftHand, int rightHand, IDisplay display, String ruleName) // TODO: IRule を引数で受け取るように書き換えよう 
    {
        var rule = GetRule(ruleName);
        var result = rule.Judge(leftHand, rightHand);
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
}