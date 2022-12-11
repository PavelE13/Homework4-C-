/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и 
возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

// Метод проверки вводимых данных
int GetNumber(string message)
{
    bool isCorrect = false;
    int result = 0;

    while (!isCorrect)
    {
        Console.Write(message);
        if (int.TryParse(Console.ReadLine(), out result))
            return result;
        else
            Console.WriteLine("Вы ввели не число");
    }
    return result;
}

//Метод расчета числа А в степени В циклом
double ResOfPow(int numberA, int numberB)
{
    double result = 1;
    if (numberB >= 0)
    {
        for (int i = 0; i < numberB; i++) result *= numberA;
    }
    else for (int i = 0; i < Math.Abs(numberB); i++) result *= (1 / (double)numberA);
    return result;
}

int numA = GetNumber("Введите целое число A: ");
int numB = GetNumber("Введите целое число B: ");
Console.WriteLine($"\nЧисло {numA} в степени {numB} = {ResOfPow(numA, numB)}");