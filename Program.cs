//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

int max = 0;
Console.WriteLine("Введите первое число = ."); 
int FirstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число = .");
int SecondNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число = .");
int ThirdNumber = Convert.ToInt32(Console.ReadLine());
if (FirstNumber > SecondNumber) max = FirstNumber;
    else max = SecondNumber;
        if (max > ThirdNumber) max = max;
        else max = ThirdNumber;

Console.WriteLine("Максимальное из трёх чисел = " + max);
