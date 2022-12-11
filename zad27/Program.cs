/* Напишите программу, которая принимает на вход число и выдаёт сумму цифр 
в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

// Метод проверки вводимых данных
int GetNumber(string message)
{
    bool isCorrect = false;
    int result = 0;

    while (!isCorrect)
    {
        Console.Write(message);
        if (int.TryParse(Console.ReadLine(), out result) && result >= 0)
            return result;
        else
            Console.WriteLine("Вы ввели не натуральное число");
    }
    return result;
}

//Метод разложения числа 
int GetSumm(int number)
{
    string charnum = string.Empty;
    charnum = Convert.ToString(number);
    int lengthnum = charnum.Length,summ=0;
    for (int i = 0; i < lengthnum; i++) 
    {
        int summ1=number%10;
        number=number/10;
        summ=summ+summ1;
    }
    return summ;
}

int num = GetNumber("Введите натуральное число: ");
Console.WriteLine($"Cумма цифр числа {num} = {GetSumm(num)}");