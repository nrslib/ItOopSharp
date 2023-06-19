var game = new JankenGame();
game.Play(1, 2, "ja");
game.Play(1, 2, "en");

//  TODO: JapaneseDisplay クラスを定義しよう

//  TODO: EnglishDisplay クラスを定義しよう

class JankenGame
{
    public void Play(int leftHand, int rightHand, String lang)
    {
        var result = Judge(leftHand, rightHand);
        ShowResult(result, lang);
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

    private void ShowResult(int result, String lang)
    {
        if (lang == "ja")
        {
            // TODO: JapaneseDisplay を使おう
        }
        else
        {
            // TODO: EnglishDisplay を使おう
        }
    }
}