namespace BudgetBook
{
    internal static class MenuManager
    {
        public static void ShowMenu()
        {
            Console.WriteLine("メニューを選択してください。(1～5で指定してください。)");
            Console.WriteLine("1. 収入を追加");
            Console.WriteLine("2. 支出を追加");
            Console.WriteLine("3. 収支を表示");
            Console.WriteLine("4. 登録した操作を削除");
            Console.WriteLine("5. CSV出力");
            Console.WriteLine("6. 終了");
        }
    }
}