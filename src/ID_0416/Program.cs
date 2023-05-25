//図のようなストップウォッチがあります．このストップウォッチには０を示す目印が一つあ
//るだけで，目盛りがありません．起動した瞬間，針は目印を指し，そこから針は軸を中心に
//一定の割合で時計回りに回転します．目盛りがないので，起動からの経過時間を直接読み取
//ることはできません．その代わり，針が目印から時計回りに a 度回ったときの経過時間が t 秒
//であることがわかっています．ただし，a は 360 度未満とします．
//角度 a と経過時間 t が与えられたとき，ストップウォッチ起動後に読み取った針の角度 r が
//表す経過時間を求めるプログラムを作成せよ．ただし，針が 1 周していないことはわかって
//いるものとする．
//入力
//１行に角度 a (1 ≤ a ≤ 359) と角度 a のときの経過時間 t (1 ≤ t ≤ 1, 000)，読み取った角度 r
//(0 ≤ r ≤ 359) がすべて整数で与えられる．ただし，a と r の単位は度，t の単位は秒とする．
//出力
//読み取った針の角度が表す経過時間を秒で１行に実数で出力する．ただし，誤差がプラスマ
//イナス 0.001 を超えてはならない．
//入力例 1
//180 120 90
//出力例 1
//60.0
//入力例 2
//90 100 120
//出力例 2
//133.333333


/// <summary>
/// 
/// </summary>
bool CheckInputRange(int value, int min, int max) => min <= value && value <= max;


for (; ; )
{
    var inputValues = Console.ReadLine();
    if(inputValues == null)
    {
        continue;
    }

    var inputList = inputValues.Split(' ');
    if (inputList.Count() != 3)
    {
        continue;
    }

    //数字チェック
    if (!int.TryParse(inputList[0], out int angle))
    {
        continue;
    }

    if (!int.TryParse(inputList[1], out int elapsedTime))
    {
        continue;
    }

    if (!int.TryParse(inputList[2], out int readAngle))
    {
        continue;
    }

    //範囲チェック
    if (!CheckInputRange(angle, 1, 359))
    {
        continue;
    }

    if (!CheckInputRange(elapsedTime, 1, 1000))
    {
        continue;

    }
    if (!CheckInputRange(readAngle, 0, 359))
    {
        continue;
    }

    //１経過時間で進む角度を計算
    double oneAngle = 1.0 * elapsedTime / angle;

    double totalElapsedTime  = oneAngle * readAngle;

    Console.WriteLine($"{totalElapsedTime}");


}
