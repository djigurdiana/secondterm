using System;

namespace BankLib
{
    public class BankAccount
    {
        public int Id { get; }
        public string Owner { get; set; }
        public decimal Balance { get; private set; }
        private static int s_nextId = 1;

        public BankAccount(string owner, decimal initialBalance)
        {
            Id = s_nextId++;
            Owner = owner;
            Balance = initialBalance < 0 ? throw new ArgumentOutOfRangeException(nameof(initialBalance)) : initialBalance;
        }

        public void Deposit(decimal amount)
        {
            if (amount < 0) throw new ArgumentOutOfRangeException(nameof(amount));
            Balance += amount;
            Console.WriteLine($"Пополнено: {amount}. Баланс: {Balance}");
        }

        public void Withdraw(decimal amount)
        {
            if (amount > Balance) throw new InvalidOperationException("Недостаточно средств");
            Balance -= amount;
            Console.WriteLine($"Снято: {amount}. Баланс: {Balance}");
        }
    }
}
