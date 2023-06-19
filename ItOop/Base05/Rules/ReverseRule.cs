using Base05.Rules;

class ReverseRule : IRule
{
    public int Judge(int leftHand, int rightHand)
    {
        if (leftHand == 0) // Goo
        {
            if (rightHand == 0) // Goo
            {
                return 0;
            }
            else if (rightHand == 1) // Choki
            {
                return -1;
            }
            else // Par
            {
                return 1;
            }
        }
        else if (leftHand == 1)
        {
            if (rightHand == 0) // Goo
            {
                return 1;
            }
            else if (rightHand == 1) // Choki
            {
                return 0;
            }
            else // Par
            {
                return -1;
            }
        }
        else
        {
            if (rightHand == 0) // Goo
            {
                return -1;
            }
            else if (rightHand == 1) // Choki
            {
                return 1;
            }
            else // Par
            {
                return 0;
            }
        }
    }
}