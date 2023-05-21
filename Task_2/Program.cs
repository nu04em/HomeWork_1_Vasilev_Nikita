// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее
Console.Clear();

Console.Write("Введите 1-ое число: ");
int firstNum = int.Parse(Console.ReadLine()!);

Console.Write("Введите 2-ое число: ");
int secondNum = int.Parse(Console.ReadLine()!);

int max = secondNum;
int min = firstNum;
string result = "Введенное вами второе число больше первого";

if (firstNum > secondNum)
    {
        max = firstNum;
        min = secondNum;
        result = "Введенное вами первое число больше второго";
    }
if (firstNum == secondNum)
    {
        Console.WriteLine("Числа равны!");
        return;
    }

Console.WriteLine(result);
Console.WriteLine($"Максимальное число: {max}");
Console.WriteLine($"Минимальное число: {min}");
