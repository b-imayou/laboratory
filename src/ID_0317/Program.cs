

const int HomeRangeMin = 1;
const int HomeRangeMax = 10000;
const int BigJunpRangeMin = 2;
const int BigJunpRangeMax = 10000;
const int JunpRange = 1;

/// <summary>
/// 
/// </summary>
bool CheckInputRange(int value, int min, int max)
{
    if (min > value || value > max)
    {
        Console.WriteLine($"入力値:{value}は範囲外です {min}～{max}");
        return false;
    }
    return true;
};


//for (; ; )
//{
//    Console.WriteLine("巣穴までの距離を入力してください");
//    var inputHomeDistance = Console.ReadLine(); // 巣までの距離
//    int homeDistanceValue = 0;
//    //数字チェック
//    if (!int.TryParse(inputHomeDistance, out homeDistanceValue))
//    {
//        Console.WriteLine($"入力値:{inputHomeDistance}は整数ではありません");
//        continue;
//    }

//    //数字範囲チェック
//    if (!CheckInputRange(homeDistanceValue,homeRangeMin, homeRangeMax))
//    {
//        continue;
//    }

//    Console.WriteLine($"大ジャンプ距離を入力してください 巣穴までの距離：{homeDistanceValue}");
//    var inputBigJumpDistance = Console.ReadLine(); // 大ジャンプ距離
//    int bigJumpDistanceValue = 0;
//    //数字チェック
//    if (!int.TryParse(inputBigJumpDistance, out bigJumpDistanceValue))
//    {
//        Console.WriteLine($"入力値:{inputBigJumpDistance}は整数ではありません");
//        continue;
//    }

//    //数字範囲チェック
//    if (!CheckInputRange(bigJumpDistanceValue, bigJunpRangeMin, bigJunpRangeMax))
//    {
//        continue;
//    }

//    Console.WriteLine($" 巣穴までの距離：{homeDistanceValue}　 大ジャンプ距離：{ bigJumpDistanceValue} ジャンプ距離：{junpRange}");

//    int bigJunpCount = homeDistanceValue / bigJumpDistanceValue;
//    int junpCount = homeDistanceValue % bigJumpDistanceValue;

//    Console.WriteLine($" 巣穴までの距離：{homeDistanceValue}　 大ジャンプ数：{ bigJunpCount} ジャンプ数：{junpCount}");
//}

for (; ; )
{
    var inputValue = Console.ReadLine();
    if (inputValue == null)
    {
        Console.WriteLine($"入力値:フォーマット異常です");
        continue;
    }

    var inputList = inputValue.Split(' ');
    if (inputList.Count() != 2)
    {
        Console.WriteLine($"入力値:フォーマット異常です");
        continue;
    }

    var d = inputList[0];
    var l = inputList[1];

    // 巣までの距離
    if (!int.TryParse(d, out int homeDistanceValue))
    {
        Console.WriteLine($"入力値:{d}は整数ではありません");
        continue;
    }
    if (!CheckInputRange(homeDistanceValue, HomeRangeMin, HomeRangeMax))
    {
        continue;
    }

    if (!int.TryParse(l, out int bigJumpDistanceValue))
    {
        Console.WriteLine($"入力値:{l}は整数ではありません");
        continue;
    }
    if (!CheckInputRange(bigJumpDistanceValue, BigJunpRangeMin, BigJunpRangeMax))
    {
        continue;
    }

    Console.WriteLine($" 巣穴までの距離：{homeDistanceValue}　 大ジャンプ距離：{ bigJumpDistanceValue} ジャンプ距離：{JunpRange}");

    int bigJunpCount = homeDistanceValue / bigJumpDistanceValue;
    int junpCount = (homeDistanceValue % bigJumpDistanceValue) * JunpRange;

    Console.WriteLine($" 巣穴までの距離：{homeDistanceValue}　 大ジャンプ数：{ bigJunpCount} ジャンプ数：{junpCount}");
    Console.WriteLine($" { bigJunpCount} {junpCount}");
}
