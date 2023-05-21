// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел

Console.Clear();

Console.Write("Введите 1-ое число: ");
int firstNum = int.Parse(Console.ReadLine()!);

Console.Write("Введите 2-ое число: ");
int secondNum = int.Parse(Console.ReadLine()!);

Console.Write("Введите 3-ое число: ");
int thirdNum = int.Parse(Console.ReadLine()!);

int max = firstNum;

if (firstNum == secondNum && secondNum == thirdNum)
    {
        Console.WriteLine("Числа равны");
        return;
    }

if (secondNum > firstNum && secondNum > thirdNum)
    max = secondNum;
if (thirdNum > firstNum && thirdNum > secondNum)
    max = thirdNum;
if (secondNum == thirdNum && firstNum < secondNum)
    max = secondNum;

Console.WriteLine($"Максимальное число: {max}");
