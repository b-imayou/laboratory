const int wordValue = 32;
const int inputValueMin = 0;
const int inputValueMax = 100;

for (; ; )
{
    Console.WriteLine("データ量 W を入力してください");
    var inputValue = Console.ReadLine(); // ユーザーの入力した文字列を1行読み込む
    int intValue = 0;

    //数字チェック
    if (!int.TryParse(inputValue, out intValue))
    {
        Console.WriteLine($"入力値:{inputValue}は整数ではありません");
        continue;
    }

    //数字範囲チェック
    if (inputValueMin > intValue || intValue > inputValueMax)
    {
        Console.WriteLine($"入力値:{inputValue}は範囲外です {inputValueMin}～{inputValueMax}");
        continue;
    }

    Console.WriteLine($"データ量Wは{intValue * wordValue}です");
}