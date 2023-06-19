Play(1, 2);

void Play(int leftHand, int rightHand)
{
    var result = Judge(leftHand, rightHand);
    ShowResult(result);
}

int Judge(int leftHand, int rightHand)
{
    // TODO: 勝敗を判定して結果（1:勝ち, 2:引き分け, 3:負け）を返却しよう
    return 0;
}

void ShowResult(int result)
{
    // TODO: 結果をもとに勝敗を print を使って表示しよう
    Console.WriteLine("結果を表示");
}