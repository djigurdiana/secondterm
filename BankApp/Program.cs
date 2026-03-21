using BankLib;

BankAccount account = new("Пользователь", 1000m);
Console.WriteLine($"Счёт {account.Id} для {account.Owner}. Начальный баланс: {account.Balance}");

account.Deposit(500m);
account.Withdraw(200m);
