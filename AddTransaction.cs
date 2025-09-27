using System;
using System.Collections.Generic;
using System.Text;

namespace BudgetBook
{
    internal class AddTransaction
    {
        public static void Add(string tran)
        {
            Console.WriteLine("取引の種類を選択してください（1: 収入, 2: 支出）:");
            string typeInput = Console.ReadLine();
            string type = typeInput == "1" ? "Income" : typeInput == "2" ? "Expense" : null;
            if (type == null)
            {
                Console.WriteLine("無効な選択です。");
                return;
            }
            Console.WriteLine("金額を入力してください:");
            if (!decimal.TryParse(Console.ReadLine(), out decimal amount) || amount <= 0)
            {
                Console.WriteLine("無効な金額です。");
                return;
            }
            Console.WriteLine("カテゴリを入力してください:");
            string category = Console.ReadLine();
            Console.WriteLine("メモを入力してください（任意）:");
            string note = Console.ReadLine();
            var transaction = new Transaction
            {
                Type = type,
                Amount = amount,
                Category = category,
                Note = note,
                Date = DateTime.Now
            };
            TransactionManager.AddTransaction(transaction);
            Console.WriteLine("取引が追加されました。");
        }

    }   
}
