using Base07.Displays;

class JapaneseDisplay : IDisplay
{
    public void Show(int result)
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