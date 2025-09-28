namespace BudgetBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {


                string chooseResult = "0";
                while (chooseResult != "6")
                {
                    MenuManager.ShowMenu();
                    chooseResult = Console.ReadLine() ?? "0";


                    switch (chooseResult)
                    {
                        case "1":
                            Console.WriteLine("収入を追加します。");
                            // 収入追加の処理をここに記述
                            ManupulationManager.AddIncome();
                            break;
                        case "2":
                            Console.WriteLine("支出を追加します。");
                            // 支出追加の処理をここに記述
                            ManupulationManager.AddExpense();
                            break;
                        case "3":
                            Console.WriteLine("収支を表示します。");
                            // 収支表示の処理をここに記述
                            ManupulationManager.DisplayBalance();
                            break;
                        case "4":
                            Console.WriteLine("登録した操作を削除します。");
                            // 登録した操作を削除の処理をここに記述
                            ManupulationManager.deleteData();
                            break;
                        case "5":
                            Console.WriteLine("CSV出力を行います。");
                            // CSV出力の処理をここに記述
                            ManupulationManager.ExportToCSV();
                            break;
                        case "6":
                            Console.WriteLine("終了します。");
                            return;
                        default:
                            Console.WriteLine("無効な選択です。");
                            break;
                    }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                if (ex.StackTrace != null)
                {
                    Console.WriteLine(ex.StackTrace);
                }
                if (ex.InnerException != null)
                {
                    Console.WriteLine("Inner Exception:");
                    Console.WriteLine(ex.InnerException.Message);
                    if (ex.InnerException.StackTrace != null)
                    {
                        Console.WriteLine(ex.InnerException.StackTrace);
                    }
                }
            }
        }
    }
}
