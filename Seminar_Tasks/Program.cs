/* Тема Урока-5 (семинар)
Функции продолжение
*/
bool CheckExit(dynamic num)
{
    if (num == 0)
    {
        Console.WriteLine("\nРабота с программой завершена, До встречи!\n");
        return true;
    }
    return false;
}

int[] GetArrowRandNumber(int size, int minRnd, int maxRnd)
{
    int[] randNumber = new int[size];
    Random int_rnd = new Random();
    int i;
    for (i = 0; i < size; i++)
        randNumber[i] = int_rnd.Next(minRnd, maxRnd + 1);
    return randNumber;
}

void ShowArr(int[] arr, string txt = "")
{
    if (txt.Length > 0) Console.WriteLine(txt);
    bool one_item = true;
    string sep;
    foreach (var item in arr)
    {
        sep = one_item ? "[" : ", ";
        one_item = false;
        Console.Write($"{sep}{item}");
    }
    Console.Write("]\n");
}

/* Задача из урока-4. 
Расчет чисел Фибоначчи с применением рекурсии.
Используется упрощенный интерфейс.
*/

// int Fibonacci(int n, int call_1, int call_2)
// int Fibonacci(int n)
// {
//     if (n == 1 || n == 2) return 1;
//     else return Fibonacci(n - 1) + Fibonacci(n - 2);
// }

// // Тело программы
// for (int i = 1; i < 40; i++)
// {
//     Console.WriteLine($"{i}! = {Fibonacci(i)}");
// }

/* Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
Найдите сумму отрицательных элементов массива.
*/
// Основное тело программы
// =======================
/*
Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное случайное число для заполнения массива: ");
int minRnd = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное случайное число: ");
int maxRnd = Convert.ToInt32(Console.ReadLine());

int summNegative = 0;
Console.Write("Содержимое массива = > ");
foreach (var item in GetArrowRandNumber(size, minRnd, maxRnd))
    {
    Console.Write($"{item}, ");
    summNegative += item < 0 ? item : 0;
    }
Console.WriteLine($"\nСумма отрицательных чисел в массиве = {summNegative}");
*/


/* Задача 32: Напишите программу для замены элементов массива: 
положительные элементы замените на соответствующие отрицательные, и наоборот.
*/
int[] GetNegativeArr(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = -arr[i];
    }
    return arr;
}

Console.WriteLine(@"Задача-32. Замена элементов массива: 
           положительные элементы замените на соответствующие отрицательные, и наоборот");
Console.WriteLine("---");
Console.WriteLine("'0' - для завершения:");

while (true)
{
    Console.Write("\nУкажите размер массива или '0' - для завершения: ");
    int dim = Convert.ToInt32(Console.ReadLine());

    if (CheckExit(dim)) break;

    Console.Write("\nВведите границы массива: ");
    int maxRnd = Convert.ToInt32(Console.ReadLine());

    int[] arr = GetArrowRandNumber(dim, -maxRnd, maxRnd + 1);
    ShowArr(arr, "Исходный массив: ");
    int[] negativeArr = GetNegativeArr(arr);
    ShowArr(negativeArr, "Обращенный массив: ");
}
// *** Конец Задачи 32 ***


/* Задача 33: Задайте массив. Напишите программу, 
которая определяет, присутствует ли заданное число в массиве.
*/
int FindNumber_inArrow(int[] arr, int findNumber)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == findNumber) return i + 1;
    }
    return 0;
}

Console.WriteLine(@"Задача-33. Ищем число в массиве");
Console.WriteLine("---");
Console.Write("\nУкажите размер массива: ");
int dim2 = Convert.ToInt32(Console.ReadLine());
int maxNumber = 100;
int[] arr2 = GetArrowRandNumber(dim2, 0, maxNumber + 1);

while (true)
{
    Console.Write($"\nВведите число для поиска (от 0 до {maxNumber}). '0' - для завершения: ");
    int number = Convert.ToInt32(Console.ReadLine());

    if (CheckExit(number)) break;

    int pos = FindNumber_inArrow(arr2, number);
    if (pos > 0)
    {
        ShowArr(arr2, "Массив поиска:");
        Console.WriteLine($"Число {number} в массиве находится под номером {pos}");
    }
    else Console.WriteLine($"Число {number} в массиве не найдено");
}
// *** Конец Задачи 33 ***


/* Задача 34: Задайте одномерный массив из 15 случайных чисел. 
Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
*/
int CountInRange(int[] arr, int begin, int end)

{
    int countNumber = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] >= begin & arr[i] <= end) ++countNumber;
    }
    return countNumber;
}

Console.WriteLine(@"Задача-34. Число элементов в массиве, находящихся в заданном диапазоне");
Console.WriteLine("---");
Console.WriteLine("'0' - для завершения:");

while (true)
{
    Console.Write("\nУкажите размер массива (или '0' для завершения): ");
    int dim3 = Convert.ToInt32(Console.ReadLine());
    if (CheckExit(dim3)) break;

    Console.Write("Введите размер диапазона для подсчета числа элементов в массиве:\n");
    Console.Write("- начало: ");
    int rangeFor = Convert.ToInt32(Console.ReadLine());
    Console.Write("- окончание: ");
    int rangeTo = Convert.ToInt32(Console.ReadLine());
    rangeTo = Math.Max(rangeTo, rangeFor);

    int maxNumber3 = (int)(rangeTo * 1.38);
    int[] arr3 = GetArrowRandNumber(dim3, 0, maxNumber3 + 1);
    ShowArr(arr3, "Массив для поиска:");

    Console.WriteLine($"Найдено {CountInRange(arr3, rangeFor, rangeTo)} элементов");
}
// *** Конец Задачи 34 ***


/* Задача 35: Найдите произведение пар чисел в одномерном массиве. 
Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21
*/
int[] PowerArr(int[] arr)
{
    int arrLength = arr.Length;
    int[] arrNew = new int[(arrLength + 1) / 2];
    for (int i = 0; i < (arrLength + 1) / 2; i++)
    {
        arrNew[i] = arr[i] * arr[arrLength - 1 - i];
    }
    return arrNew;
}

Console.WriteLine(@"Задача-35. Преобразование массива - 
           произведение равноудаленных пар элементов массива");
Console.WriteLine("---");
Console.WriteLine("'0' - для завершения:");
int maxNumber4 = 20;

while (true)
{
    Console.Write("\nУкажите размер массива (или '0' для завершения): ");
    int dim4 = Convert.ToInt32(Console.ReadLine());
    if (CheckExit(dim4)) break;

    int[] arr4 = GetArrowRandNumber(dim4, 0, maxNumber4 + 1);

    ShowArr(arr4, "Исходный массив: ");
    int[] powerArr = PowerArr(arr4);
    ShowArr(powerArr, "Обращенный массив: ");
}
// *** Конец Задачи 35 ***
