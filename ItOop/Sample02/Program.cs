var game = new JankenGame();
game.Play(1, 2);
game.Play(1, 2);

class JankenGame
{
    public void Play(int leftHand, int rightHand)
    {
        var result = Judge(leftHand, rightHand);
        ShowResult(result);
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

    private void ShowResult(int result)
    {
        if (result == 1)
        {
            Console.WriteLine("勝ち");
        }
        else if (result == 0)
        {
            Console.WriteLine("引き分け");
        }
        else
        {
            Console.WriteLine("負け");
        }
    }
}