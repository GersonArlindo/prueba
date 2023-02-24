// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using BankConsole;

User Arlindo = new User();

Arlindo.ID = 1;
Arlindo.Name = "Gerson Arlindo Gonzalez";
Arlindo.Email = "arlindo@gmail.com";
Arlindo.Balance = 1000;
Arlindo.RegisterDate = DateTime.Now;

Console.WriteLine(Arlindo.ShowData());