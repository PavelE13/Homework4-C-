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
int ResOfPow(int numberA, int numberB)
{
    int result=1;
    for(int i=0;i<numberB;i++) result*=numberA;
    return result;
}

int numA = GetNumber("Введите натуральное число A: ");
int numB = GetNumber("Введите натуральное число B: ");
Console.WriteLine($"\nЧисло {numA} в степени {numB} = {ResOfPow(numA,numB)}");