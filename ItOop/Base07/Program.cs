using Base07.Displays;
using Base07.Rules;

var game = new JankenGame();
game.Play(0, 2, new JapaneseDisplay(), new NormalRule());
game.Play(1, 2, new JapaneseDisplay(), new NormalRule());
game.Play(2, 2, new JapaneseDisplay(), new NormalRule());
game.Play(0, 2, new JapaneseDisplay(), new ReverseRule());
game.Play(1, 2, new JapaneseDisplay(), new ReverseRule());
game.Play(2, 2, new JapaneseDisplay(), new ReverseRule());

// TODO: コンストラクタを定義して、display と rule を受け取ってフィールドに格納して利用しよう
class JankenGame
{
    public void Play(int leftHand, int rightHand, IDisplay display, IRule rule)
    {
        var result = rule.Judge(leftHand, rightHand);
        display.Show(result);
    }
}