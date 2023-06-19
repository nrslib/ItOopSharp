using Sample07.Displays;

class EnglishDisplay : IDisplay
{
    public void Show(int result)
    {
        if (result == 1)
        {
            Console.WriteLine("win");
        }
        else if (result == 0)
        {
            Console.WriteLine("draw");
        }
        else
        {
            Console.WriteLine("lose");
        }
    }
}