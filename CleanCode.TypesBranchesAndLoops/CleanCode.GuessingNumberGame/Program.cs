// See https://aka.ms/new-console-template for more information
using System.Text;

Console.InputEncoding = Encoding.Unicode;
Console.OutputEncoding = Encoding.UTF8;
Console.WriteLine("Добро пожаловать в игру!");

string userName = string.Empty;
bool isValidName = false;
do 
{
    Console.WriteLine("Как тебя зовут?");
    userName = Console.ReadLine().Trim();
    if (string.IsNullOrWhiteSpace(userName))
    {
        Console.WriteLine("Имя не может быть пустым");
    }
    else if (userName.Length < 2)
    {
        Console.WriteLine("Имя не может быть меньше 2-х букв");
    }
    else
    {
        isValidName = true;
    }

} while (!isValidName);

Console.WriteLine($"Привет, {userName}! Я загадал для тебя число. Попробуй отгадать");

int startNumber = 0;
int endNumber = 999;
Random randomGenerator = new Random();
int randomNumber = randomGenerator.Next(startNumber, endNumber + 1);

int secretNumeber = randomGenerator.Next(startNumber, randomNumber + 1);
Console.WriteLine(secretNumeber);

bool isContinue = true;
bool isWin = false;

int userNumber = -1;
bool isIntNumber = false;

int stepCount = 0;

while (isContinue)
{
    // game
    do
    {
        // input user number
        do
        {
            Console.WriteLine($"Введите число от {startNumber} до {randomNumber}");
            string? inputNumber = Console.ReadLine().Trim();
            isIntNumber = int.TryParse(inputNumber, out userNumber);

            if (!isIntNumber)
            {
                Console.WriteLine($"Вы ввелии: {inputNumber}, нужно ввести число от {startNumber} до {randomNumber}");
            }

        } while (!isIntNumber);

        stepCount++;

        if (userNumber < 0 || userNumber > randomNumber)
        {
            Console.WriteLine($"Ваше число запределами заданного диапазона от {startNumber} до {randomNumber}");
        }
        else if (userNumber > secretNumeber)
        {
            Console.WriteLine($"Ваше число {userNumber} больше, чем загаданное");
        }
        else if (userNumber < secretNumeber)
        {
            Console.WriteLine($"Ваше число {userNumber} меньше, чем загаданное");
        }
        else
        {
            isWin = true;
            Console.WriteLine($"{userName}, вы угадали число!");
            Console.WriteLine($"Число попыток: {stepCount}");
        }

    } while (!isWin);

    // repeat game
    bool isValidAnswer = false;
    do
    {
        Console.WriteLine("Ещё раз? Введите y/n");
        string? userAnswer = Console.ReadLine().Trim().ToLower();

        if (string.IsNullOrEmpty(userAnswer))
        {
            Console.WriteLine("В ответе пусто");
        }
        else if (userAnswer == "y")
        {
            isContinue = true;
            isValidAnswer = true;
            Console.Clear();
            stepCount = 0;
            isWin = false;
            randomNumber = randomGenerator.Next(startNumber, endNumber + 1);
            secretNumeber = randomGenerator.Next(startNumber, randomNumber + 1);
            Console.WriteLine(secretNumeber);
        }
        else if (userAnswer == "n")
        {
            isContinue = false;
            isValidAnswer = true;
        }

    } while (!isValidAnswer);
}
