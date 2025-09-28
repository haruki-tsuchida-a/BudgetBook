using System;
using System.Collections.Generic;
using System.Text;

namespace BudgetBook
{
    internal static class ManupulationManager
    {
        public static void AddIncome()
        {
            Console.WriteLine("収入を追加します。");
            // 収入追加の処理をここに記述
            Console.WriteLine("金額を入力してください。");
            string? inputStr = Console.ReadLine();
            if (int.TryParse(inputStr, out int input))
            {
                // 入力値inputを使用した処理をここに記述
            }
            else
            {
                Console.WriteLine("無効な入力です。数値を入力してください。");
            }
        }
        public static void AddExpense()
        {
            Console.WriteLine("支出を追加します。");
            // 支出追加の処理をここに記述
        }
        public static void DisplayBalance()
        {
            Console.WriteLine("収支を表示します。");
            // 収支表示の処理をここに記述
        }
        public static void deleteData()
        {

        }


        public static void ExportToCSV()
        {
            Console.WriteLine("CSV出力を行います。");
            string path = ConfigurationHelper.GetCsvPath();
            // ここでpathを使ってCSVファイルを出力
            Console.WriteLine($"CSVファイルの出力先: {path}");
            // 例: File.WriteAllText(path, csvContent);
        }
    }
}
