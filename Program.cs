namespace BudgetBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("メニューを選択してください。");
            Console.WriteLine("1. 収入を追加");
            Console.WriteLine("2. 支出を追加");
            Console.WriteLine("3. 収支を表示");
            Console.WriteLine("4. CSV出力");
            Console.WriteLine("5. 終了");

            string chooseResult = Console.ReadLine();

            switch (chooseResult)
            {
                case "1":
                    Console.WriteLine("収入を追加します。");
                    // 収入追加の処理をここに記述
                    break;
                case "2":
                    Console.WriteLine("支出を追加します。");
                    // 支出追加の処理をここに記述
                    break;
                case "3":
                    Console.WriteLine("収支を表示します。");
                    // 収支表示の処理をここに記述
                    break;
                case "4":
                    Console.WriteLine("CSV出力を行います。");
                    // CSV出力の処理をここに記述
                    break;
                case "5":
                    Console.WriteLine("終了します。");
                    return;
                default:
                    Console.WriteLine("無効な選択です。");
                    break;
            }
        }
    }
}
