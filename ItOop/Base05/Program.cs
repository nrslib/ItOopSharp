using Base05.Displays;

var game = new JankenGame();
game.Play(1, 2, "ja", "default");
game.Play(1, 2, "en", "reverse");

class JankenGame
{
    /// <param name="lang">ja:日本語,en:英語</param>
    /// <param name="ruleName">default:通常,reverse:逆</param>
    public void Play(int leftHand, int rightHand, String lang, String ruleName)
    {
        //  TODO: IRule を使うように書き換えよう
        var result = Judge(leftHand, rightHand);
        var display = GetDisplay(lang);
        display.Show(result);
    }

    private int Judge(int leftHand, int rightHand)
    {
        if (leftHand == 0) // Goo
        {
            if (rightHand == 0) // Goo
            {
                return 0;
            }
            else if (rightHand == 1) // Choki
            {
                return 1;
            }
            else // Par
            {
                return -1;
            }
        }
        else if (leftHand == 1)
        {
            if (rightHand == 0) // Goo
            {
                return -1;
            }
            else if (rightHand == 1) // Choki
            {
                return 0;
            }
            else // Par
            {
                return 1;
            }
        }
        else
        {
            if (rightHand == 0) // Goo
            {
                return 1;
            }
            else if (rightHand == 1) // Choki
            {
                return -1;
            }
            else // Par
            {
                return 0;
            }
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