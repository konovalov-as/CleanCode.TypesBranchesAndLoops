// See https://aka.ms/new-console-template for more information
using System.Text;

Console.InputEncoding = Encoding.Unicode;
Console.OutputEncoding = Encoding.UTF8;
Console.WriteLine("Добро пожаловать в игру!");
Console.WriteLine("Как тебя зовут?");
string? userName = Console.ReadLine();
Console.WriteLine(
    $"Привет, {userName}. " +
    $"Я загадал для тебя число от 0 до 99. " +
    $"Попробуй отгадать");

string? inputNumber = Console.ReadLine();
Console.WriteLine($"Вы ввели число {inputNumber}");
