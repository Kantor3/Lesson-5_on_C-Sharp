/*
Урок 5. Функции продолжение
====================================================================
*/

/*
Общие методы
*/
// Организация завершения работы с модулем
bool CheckExit(dynamic num)
{
    if (num == 0)
    {
        Console.WriteLine("\nРабота с программой завершена, До встречи!\n");
        return true;
    }
    return false;
}

// Создание массива заполненных случайно сгенерированными целыми числами
int[] GetArrowRandNumber(int size, int minRnd, int maxRnd)
{
    int[] randNumber = new int[size];
    Random int_rnd = new Random();
    int i;
    for (i = 0; i < size; i++)
        randNumber[i] = int_rnd.Next(minRnd, maxRnd + 1);
    return randNumber;
}

// Вывод содержимого массива
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


/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
Пример: [345, 897, 568, 234] -> 2
*/
int CountEvenArr(int[] arr)
{
    int countEvenNumber = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0) ++countEvenNumber;
    }
    return countEvenNumber;
}

Console.WriteLine(@"Задача-34. Подсчет количества чётных чисел в массиве");
Console.WriteLine("---");
Console.WriteLine("'0' - для завершения:");
int minNumber_34 = 111;
int maxNumber_34 = 999;

while (true)
{
    Console.Write("\nУкажите размер массива трехзначных чисел (или '0' для завершения): ");
    int dim_34 = Convert.ToInt32(Console.ReadLine());
    if (CheckExit(dim_34)) break;

    int[] arr_34 = GetArrowRandNumber(dim_34, minNumber_34, maxNumber_34 + 1);

    ShowArr(arr_34, "Исходный массив: ");
    Console.WriteLine($"Число четных чисел в массиве = {CountEvenArr(arr_34)}");
}
// *** Конец Задачи 34 ***


/* Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
Пример: [3, 7, 23, 12] -> 19
        [-4, -6, 89, 6] -> 0
*/
int SumEvenPosArr(int[] arr)
{
    int sumEvenPos = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 == 0) sumEvenPos += arr[i];
    }
    return sumEvenPos;
}

Console.WriteLine(@"Задача-36. Расчет суммы элементов, стоящих на нечётных позициях");
Console.WriteLine("---");
Console.WriteLine("'0' - для завершения:");
int minNumber_36 = 0;
int maxNumber_36 = 100;

while (true)
{
    Console.Write("\nУкажите размер массива (или '0' для завершения): ");
    int dim_36 = Convert.ToInt32(Console.ReadLine());
    if (CheckExit(dim_36)) break;

    int[] arr_36 = GetArrowRandNumber(dim_36, minNumber_36, maxNumber_36 + 1);

    ShowArr(arr_36, "Исходный массив: ");
    Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях = {SumEvenPosArr(arr_36)}");
}
// *** Конец Задачи 36 ***


/* Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементами массива.
Пример: [3 7 22 2 78] -> 76
*/
int DivMaxMinArr(int[] arr)
{
    int minElem = arr[0], maxElem = minElem;
    foreach (var item in arr)
    {
        minElem = Math.Min(minElem, item);
        maxElem = Math.Max(maxElem, item);
    }
    return maxElem - minElem;
}

Console.WriteLine(@"Задача-38. Расчет разницы между максимальным и минимальным элементами массива");
Console.WriteLine("---");
Console.WriteLine("'0' - для завершения:");
int minNumber_38 = 0;
int maxNumber_38 = 100;

while (true)
{
    Console.Write("\nУкажите размер массива (или '0' для завершения): ");
    int dim_38 = Convert.ToInt32(Console.ReadLine());
    if (CheckExit(dim_38)) break;

    int[] arr_38 = GetArrowRandNumber(dim_38, minNumber_38, maxNumber_38 + 1);

    ShowArr(arr_38, "Исходный массив: ");
    Console.WriteLine($"Разница между максимальным и минимальным элементами массива = {DivMaxMinArr(arr_38)}");
}
// *** Конец Задачи 38 ***