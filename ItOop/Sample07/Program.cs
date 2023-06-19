using Sample07.Displays;
using Sample07.Rules;

var display = new JapaneseDisplay();
var rule = new NormalRule();
var game = new JankenGame(display, rule);
game.Play(0, 2);
game.Play(1, 2);
game.Play(2, 2);
game.Play(0, 2);
game.Play(1, 2);
game.Play(2, 2);

class JankenGame
{
    private IDisplay display;
    private IRule rule;

    public JankenGame(IDisplay display, IRule rule)
    {
        this.display = display;
        this.rule = rule;
    }
    
    public void Play(int leftHand, int rightHand)
    {
        var result = rule.Judge(leftHand, rightHand);
        display.Show(result);
    }
}