/* Напишите программу, которая задаёт массив из 8 элементов и выводит их на 
экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

// Метод проверки данных на размерность массива
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

//Метод заполнения и вывода массива 
void GenerateArray(int num, int raz)
{
    int[] array = new int[num];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(raz);
        Console.Write($" {array[i]} ");
    }
}

int num = GetNumber("Введите размерность массива (натуральное число): ");
int raz = GetNumber("Введите максимальное значение элемента массива (натуральное число): ");
GenerateArray(num, raz);