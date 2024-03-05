using System;
using System.Collections;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        ArrayList arraylist = new ArrayList() { 5, 3, 7, 1, 9 };
        int[] array = { 5, 3, 7, 1, 9 };
        SortedList<string, string> sortedlist = new SortedList<string, string>();
        while (true)
        {
            Console.WriteLine("1. Array"); Console.WriteLine("2. ArrayList");
            Console.WriteLine("3. SortedList");
            int choice;
            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Неверный ввод.");
                continue;
            }
            switch (choice)
            {
                case 1:
                    GoArray(array);
                    break;
                case 2:
                    GoArrayList(arraylist);
                    break;
                case 3:
                    GoSortedList(sortedlist);
                    break;
                default:
                    Console.WriteLine("Неверный выбор.");
                    break;
            }
        }
    }
    static void GoArray(int[] array)
    {
        while (true)
        {
            Console.WriteLine("Выберите операцию для массива чисел:");
            Console.WriteLine("1. Count");
            Console.WriteLine("2. Binary Search");
            Console.WriteLine("3. Copy");
            Console.WriteLine("4. Find");
            Console.WriteLine("5. FindLast");
            Console.WriteLine("6. IndexOf");
            Console.WriteLine("7. Reverse");
            Console.WriteLine("8. Resize");
            Console.WriteLine("9. Sort");
            Console.WriteLine("0. Выйти");
            int choice1;
            if (!int.TryParse(Console.ReadLine(), out choice1))
            {
                Console.WriteLine("Неверный ввод."); continue;
            }
            switch (choice1)
            {
                case 0:
                    return;
                case 1:
                    Console.WriteLine($"Количество элементов: {array.Length}");
                    break;
                case 2:
                    Console.Write("Введите значение для поиска: ");
                    int searchValue = int.Parse(Console.ReadLine());
                    int index = Array.BinarySearch(array, searchValue);
                    if (index >= 0)
                        Console.WriteLine($"Значение найдено и имеет индекс {index}");
                    else
                        Console.WriteLine("Значение не найдено");
                    break;
                case 3:
                    int[] copy = new int[array.Length];
                    Array.Copy(array, copy, array.Length);
                    Console.Write("Скопированный массив: ");
                    foreach (var num in copy)
                    {
                        Console.Write($"{num} ");
                    }
                    Console.WriteLine();
                    break;
                case 4:
                    Console.Write("Введите значение для поиска: ");
                    int findValue = int.Parse(Console.ReadLine());
                    int foundIndex = Array.FindIndex(array, num => num == findValue);
                    if (foundIndex != -1)
                        Console.WriteLine($"Значение {findValue} найдено и имеет индекс {foundIndex}");
                    else
                        Console.WriteLine("Значение не найдено");
                    break;
                case 5:
                    Console.Write("Введите значение для поиска: ");
                    int findLastValue = int.Parse(Console.ReadLine());
                    int foundLastIndex = Array.FindLastIndex(array, num => num == findLastValue);
                    if (foundLastIndex != -1)
                        Console.WriteLine($"Значение {findLastValue} найдено и имеет индекс {foundLastIndex}");
                    else
                        Console.WriteLine("Значение не найдено");
                    break;
                case 6:
                    Console.Write("Введите значение для поиска: ");
                    int indexOfValue = int.Parse(Console.ReadLine());
                    int indexOfNum = Array.IndexOf(array, indexOfValue);
                    if (indexOfNum != -1)
                        Console.WriteLine($"Значение {indexOfValue} найдено и имеет индекс {indexOfNum}");
                    else
                        Console.WriteLine("Значение не найдено");
                    break;
                case 7:
                    Array.Reverse(array);
                    Console.Write("Результат разворота массива: ");
                    foreach (var num in array)
                    {
                        Console.Write($"{num} ");
                    }
                    Console.WriteLine();
                    break;
                case 8:
                    Console.Write("Введите новый размер массива: ");
                    int newSize;
                    if (!int.TryParse(Console.ReadLine(), out newSize) || newSize < 0)
                    {
                        Console.WriteLine("Некорректный размер. Попробуйте снова.");
                        continue;
                    }
                    Array.Resize(ref array, newSize);
                    Console.WriteLine("Массив успешно изменен");
                    break;
                case 9:
                    Array.Sort(array);
                    Console.Write("Отсортированный массив: ");
                    foreach (var num in array)
                    {
                        Console.Write($"{num} ");
                    }
                    Console.WriteLine();
                    break;
                default:
                    Console.WriteLine("Неверный выбор операции.");
                    break;
            }
        }
    }
    static void GoArrayList(ArrayList arraylist)
    {
        while (true)
        {
            Console.WriteLine("Выберите операцию для ArrayList:");
            Console.WriteLine("1. Count");
            Console.WriteLine("2. Binary Search");
            Console.WriteLine("3. Copy");
            Console.WriteLine("4. IndexOf");
            Console.WriteLine("5. Insert");
            Console.WriteLine("6. Reverse");
            Console.WriteLine("7. Sort");
            Console.WriteLine("8. Add");
            Console.WriteLine("0. Выйти");
            int choice2;
            if (!int.TryParse(Console.ReadLine(), out choice2))
            {
                Console.WriteLine("Неверный ввод. Попробуйте снова.");
                continue;
            }

            switch (choice2)
            {
                case 0:
                    return;
                case 1:
                    Console.WriteLine($"Количество элементов: {arraylist.Count}");
                    break;
                case 2:
                    Console.Write("Введите значение для поиска: ");
                    int searchValue = int.Parse(Console.ReadLine());
                    int index = arraylist.BinarySearch(searchValue);
                    if (index >= 0)
                        Console.WriteLine($"Значение найдено и имеет индекс {index}");
                    else
                        Console.WriteLine("Значение не найдено");
                    break;
                case 3:
                    ArrayList copy = (ArrayList)arraylist.Clone();
                    Console.Write("Копия ArrayList: ");
                    foreach (var item in copy)
                    {
                        Console.Write($"{item} ");
                    }
                    Console.WriteLine();
                    break;
                case 4:
                    Console.Write("Введите значение для поиска: ");
                    int findValue = int.Parse(Console.ReadLine());
                    int foundIndex = arraylist.IndexOf(findValue);
                    if (foundIndex != -1)
                        Console.WriteLine($"Значение {findValue} найдено и имеет индекс {foundIndex}");
                    else
                        Console.WriteLine("Значение не найдено");
                    break;
                case 5:
                    Console.Write("Введите значение для вставки: ");
                    int insertValue = int.Parse(Console.ReadLine());
                    Console.Write("Введите индекс для вставки: ");
                    int insertIndex = int.Parse(Console.ReadLine());
                    arraylist.Insert(insertIndex, insertValue);
                    Console.WriteLine($"Значение {insertValue} успешно вставлено на индекс {insertIndex}");
                    break;
                case 6:
                    arraylist.Reverse();
                    Console.Write("Результат разворота ArrayList: ");
                    foreach (var item in arraylist)
                    {
                        Console.Write($"{item} ");
                    }
                    Console.WriteLine();
                    break;
                case 7:
                    arraylist.Sort();
                    Console.Write("Отсортированный ArrayList: ");
                    foreach (var item in arraylist)
                    {
                        Console.Write($"{item} ");
                    }
                    Console.WriteLine();
                    break;
                case 8:
                    Console.Write("Введите значение для добавления: ");
                    int addValue = int.Parse(Console.ReadLine());
                    arraylist.Add(addValue);
                    Console.WriteLine($"Значение {addValue} успешно добавлено в ArrayList");
                    break;
                default:
                    Console.WriteLine("Неверный выбор операции.");
                    break;
            }
        }
    }
    static void GoSortedList(SortedList<string, string> sortedlist)
    {
        while (true)
        {
            Console.WriteLine("Выберите операцию для SortedList:");
            Console.WriteLine("1. Add");
            Console.WriteLine("2. IndexOf по ключу");
            Console.WriteLine("3. IndexOf по значению");
            Console.WriteLine("4. Вывод ключа по индексу");
            Console.WriteLine("5. Вывод значения по индексу");
            Console.WriteLine("0. Выйти");
            int choice3;
            if (!int.TryParse(Console.ReadLine(), out choice3))
            {
                Console.WriteLine("Неверный ввод. Попробуйте снова.");
                continue;
            }
            switch (choice3)
            {
                case 0:
                    return;
                case 1:
                    Console.Write("Введите количество пар для добавления: ");
                    if (!int.TryParse(Console.ReadLine(), out int count))
                    {
                        Console.WriteLine("Неверный ввод. Попробуйте снова.");
                        continue;
                    }
                    for (int i = 0; i < count; i++)
                    {
                        Console.Write("Введите ключ: ");
                        string key = Console.ReadLine();
                        Console.Write("Введите значение: ");
                        string value = Console.ReadLine();
                        sortedlist.Add(key, value);
                    }
                    Console.WriteLine("Пары успешно добавлены в SortedList");
                    break;
                case 2:
                    Console.Write("Введите ключ для поиска: ");
                    string searchKey = Console.ReadLine();
                    if (sortedlist.ContainsKey(searchKey))
                        Console.WriteLine($"Индекс ключа '{searchKey}': {sortedlist.IndexOfKey(searchKey)}");
                    else
                        Console.WriteLine("Ключ не найден");
                    break;
                case 3:
                    Console.Write("Введите значение для поиска: ");
                    string searchValue = Console.ReadLine();
                    if (sortedlist.ContainsValue(searchValue))
                        Console.WriteLine($"Индекс значения '{searchValue}': {sortedlist.IndexOfValue(searchValue)}");
                    else
                        Console.WriteLine("Значение не найдено");
                    break;
                case 4:
                    Console.Write("Введите индекс ключа: ");
                    int keyIndexInput = int.Parse(Console.ReadLine());
                    if (keyIndexInput >= 0 && keyIndexInput < sortedlist.Count)
                        Console.WriteLine($"Ключ по индексу {keyIndexInput}: {sortedlist.Keys[keyIndexInput]}");
                    else
                        Console.WriteLine("Некорректный индекс");
                    break;
                case 5:
                    Console.Write("Введите индекс значения: ");
                    int valueIndexInput = int.Parse(Console.ReadLine());
                    if (valueIndexInput >= 0 && valueIndexInput < sortedlist.Count)
                        Console.WriteLine($"Значение по индексу {valueIndexInput}: {sortedlist.Values[valueIndexInput]}");
                    else
                        Console.WriteLine("Некорректный индекс");
                    break;
                default:
                    Console.WriteLine("Неверный выбор операции.");
                    break;
            }
        }
    }
}