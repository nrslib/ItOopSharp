Play(1, 2);

void Play(int leftHand, int rightHand)
{
    var result = Judge(leftHand, rightHand);
    ShowResult(result);
}

int Judge(int leftHand, int rightHand)
{
    if (leftHand == 0) // Goo
    {
        if (rightHand == 0) // Goo
        {
            return 2;
        }
        else if (rightHand == 1) // Choki
        {
            return 1;
        }
        else // Par
        {
            return 3;
        }
    }
    else if (leftHand == 1)
    {
        if (rightHand == 0) // Goo
        {
            return 3;
        }
        else if (rightHand == 1) // Choki
        {
            return 2;
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
            return 3;
        }
        else // Par
        {
            return 2;
        }
    }
}

void ShowResult(int result)
{
    if (result == 1)
    {
        Console.WriteLine("勝ち");
    }
    else if (result == 2)
    {
        Console.WriteLine("引き分け");
    }
    else
    {
        Console.WriteLine("負け");
    }
}