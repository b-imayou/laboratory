

const int homeRangeMin = 0;
const int homeRangeMax = 10000;
const int bigJunpRangeMin = 2;
const int bigJunpRangeMax = 10000;
const int junpRange = 1;

/// <summary>
/// 
/// </summary>
bool CheckInputRange(int value , int min , int max)
{
    if (min > value || value > max)
    {
        Console.WriteLine($"入力値:{value}は範囲外です {min}～{max}");
        return false;
    }
    return true;
};


for (; ; )
{
    Console.WriteLine("巣穴までの距離を入力してください");
    string inputHomeDistance = Console.ReadLine(); // 巣までの距離
    int homeDistanceValue = 0;
    //数字チェック
    if (!int.TryParse(inputHomeDistance, out homeDistanceValue))
    {
        Console.WriteLine($"入力値:{inputHomeDistance}は整数ではありません");
        continue;
    }

    //数字範囲チェック
    if (!CheckInputRange(homeDistanceValue,homeRangeMin, homeRangeMax))
    {
        continue;
    }

    Console.WriteLine($"大ジャンプ距離を入力してください 巣穴までの距離：{homeDistanceValue}");
    string inputBigJumpDistance = Console.ReadLine(); // 大ジャンプ距離
    int bigJumpDistanceValue = 0;
    //数字チェック
    if (!int.TryParse(inputBigJumpDistance, out bigJumpDistanceValue))
    {
        Console.WriteLine($"入力値:{inputBigJumpDistance}は整数ではありません");
        continue;
    }

    //数字範囲チェック
    if (!CheckInputRange(bigJumpDistanceValue, bigJunpRangeMin, bigJunpRangeMax))
    {
        continue;
    }

    Console.WriteLine($" 巣穴までの距離：{homeDistanceValue}　 大ジャンプ距離：{ bigJumpDistanceValue} ジャンプ距離：{junpRange}");

    int bigJunpCount = homeDistanceValue / bigJumpDistanceValue;
    int junpCount = homeDistanceValue % bigJumpDistanceValue;

    Console.WriteLine($" 巣穴までの距離：{homeDistanceValue}　 大ジャンプ数：{ bigJunpCount} ジャンプ数：{junpCount}");
}

