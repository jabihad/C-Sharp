using System;
using System.Threading;
namespace Test
{
    public class Account
    {
        public int id { get; }
        private double balance;

        public Account(int _id, double _balance)
        {
            id = _id;
            balance = _balance;
        }

        public void WithdrawMoney(double amount)
        {
            balance -= amount;
        }

        public void DepositMoney(double amount)
        {
            balance += amount;
        }
    }
    public class AccountManager
    {
        private Account FromAccount;
        private Account ToAccount;
        private double TransferAmount;

        public AccountManager(Account _FromAccount, Account _ToAccount, double _TransferAmmount)
        {
            FromAccount = _FromAccount;
            ToAccount = _ToAccount;
            TransferAmount = _TransferAmmount;
        }
        public void FundTransfer()
        {
            Console.WriteLine($"{Thread.CurrentThread.Name} is trying to acquire lock on {FromAccount.id}");
            lock(FromAccount)
            {
                Console.WriteLine($"{Thread.CurrentThread.Name} acquired lock on {FromAccount.id}");
                Console.WriteLine($"{Thread.CurrentThread.Name} is doing database work");
                Thread.Sleep(1000);
                Console.WriteLine($"{Thread.CurrentThread.Name} is trying to acquire lock on {ToAccount.id}");

                lock(ToAccount)
                {
                    FromAccount.WithdrawMoney(TransferAmount);
                    ToAccount.DepositMoney(TransferAmount);
                }
            }
        }
    }
    
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Main Thread Started");

            Account Account101 = new Account(101, 2500);
            Account Account102 = new Account(102, 5000);

            AccountManager accountmanager1 = new AccountManager(Account101, Account102, 500);
            Thread thread1 = new Thread(accountmanager1.FundTransfer)
            {
                Name = "Thread1"
            };

            AccountManager accountmanager2 = new AccountManager(Account102, Account101, 800);
            Thread thread2 = new Thread(accountmanager2.FundTransfer)
            {
                Name = "Thread2"
            };

            thread1.Start();
            thread2.Start();

            thread1.Join();
            thread2.Join();

            Console.WriteLine("Main Thread Ended");
        }
    }

}
