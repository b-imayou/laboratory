
class CoinClass
{
    /// <summary>
    /// コイン数
    /// </summary>
    public int CoinCount { get; set; }
    /// <summary>
    /// 乗数
    /// </summary>
    public int Multiplier { get; set; }

    /// <summary>
    /// コンストラクタ
    /// </summary>
    /// <param name="multiplier"></param>
    public CoinClass(int multiplier)
    {
        this.CoinCount = 0;
        this.Multiplier = multiplier;
    }
    
    /// <summary>
    /// 現在の金額を返す
    /// </summary>
    /// <returns></returns>
    public int GetMoney() => this.CoinCount * this.Multiplier;

    /// <summary>
    /// 受け取った文字列をコイン数としてセット
    /// </summary>
    /// <param name="target"></param>
    /// <returns></returns>
    public bool SetCoinCount(string target)
    {
        if (!int.TryParse(target, out int cCount))
        {
            return false;
        }
        else
        {
            if (0 <= cCount && cCount <= 50)
            {
                this.CoinCount = cCount;
                return true;

            }
            else
            {
                this.CoinCount = 0;
                return false;
            }
        }
    }    
};

class Program
{
    static void Main(string[] args)
    {
        for (; ; )
        {
            var inputValues = Console.ReadLine();
            if (inputValues == null)
            {
                continue;
            }

            var c1 = new CoinClass(1);
            var c5 = new CoinClass(5);
            var c10 = new CoinClass(10);
            var c50 = new CoinClass(50);
            var c100 = new CoinClass(100);
            var c500 = new CoinClass(500);

            var inputList = inputValues.Split(' ');
            if (inputList.Count() != 6)
            {
                continue;
            }

            c1.SetCoinCount(inputList[0]);
            c5.SetCoinCount(inputList[1]);
            c10.SetCoinCount(inputList[2]);
            c50.SetCoinCount(inputList[3]);
            c100.SetCoinCount(inputList[4]);
            c500.SetCoinCount(inputList[5]);

            var totalMoney = new List<CoinClass>() { c1, c5, c10, c50, c100, c500 }
                                .Select((r) => r.GetMoney())
                                .Sum();

            if ((totalMoney / 1000) != 0)
            {
                Console.WriteLine("1");
            }
            else
            {
                Console.WriteLine("0");
            }

        }
    }
}
    

       



